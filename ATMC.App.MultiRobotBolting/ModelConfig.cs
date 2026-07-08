using Abeo.Controls.Common;
using ATMC.Common;
using LotusAPI;
using LotusAPI.Controls.Editors;
using LotusAPI.Math;
using LotusAPI.MV;
using LotusAPI.Robotics;
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Threading.Tasks;

namespace ATMC.App.MultiRobotBolting {

    [JsonSerializable]
    [TypeConverter(typeof(AbeoTypeConverter))]
    public class BatteryRegistration : RegistrationConfig {

        [JsonSkip] internal Pointcloud Model_WithOutS0 = null;
        [JsonSkip] internal Pointcloud Model_WithOutS1 = null;
        [JsonSkip] internal Pointcloud Model_WithOutS2 = null;
        [JsonSkip] internal Pointcloud Model_WithOutS3 = null;

        public override void Init(string model_dir, string prefix = "", string suffix = "") {
            try {
                base.Init(model_dir, prefix, suffix);

                //Init body size correction model
                //initialize side models
                string model_withouts0_file = model_dir + "/model_without0_cc.ply";
                string model_withouts1_file = model_dir + "/model_without1_cc.ply";
                string model_withouts2_file = model_dir + "/model_without2_cc.ply";
                string model_withouts3_file = model_dir + "/model_without3_cc.ply";

                if (File.Exists(model_withouts0_file)) {
                    Model_WithOutS0 = Pointcloud.ReadPLY(model_withouts0_file);
                }
                if (File.Exists(model_withouts1_file)) {
                    Model_WithOutS1 = Pointcloud.ReadPLY(model_withouts1_file);
                }
                if (File.Exists(model_withouts2_file)) {
                    Model_WithOutS2 = Pointcloud.ReadPLY(model_withouts2_file);
                }
                if (File.Exists(model_withouts3_file)) {
                    Model_WithOutS3 = Pointcloud.ReadPLY(model_withouts3_file);
                }
            }
            catch (Exception ex) { Logger.Error(ex.Message); Logger.Trace(ex.StackTrace); }
        }
    }

    //Define car model configurations
    [JsonSerializable]
    [TypeConverter(typeof(AbeoTypeConverter))]
    public class ModelConfig : ModelConfigBase {
        //Coarse align
        [Category("REGISTRATION")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public BatteryRegistration Registration { get; set; } = new BatteryRegistration();

        [Category("GENERAL")]
        [JsonSkip]
        public bool Valid => Registration != null && Registration.Valid;

        //Create a new result
        public Result CreateResult() {
            return new Result(this);
        }

        public override void Init() {
            try {
                Registration = Registration ?? new BatteryRegistration();
                if(Directory.Exists(ModelDir)) {
                    //init pick model
                    Registration.Init(ModelDir, "", "cc");
                }

            } catch(Exception ex) { LotusAPI.Logger.Error(ex.Message); }
        }

        public RegistrationResult Align(Pointcloud scene, Pointcloud Model, bool check_fitness = true, bool check_overlap = true, bool check_limit = true) {

            Logger.Debug("Aligning scene...");
            RegistrationResult registrationResult = new RegistrationResult();

            Pointcloud pointcloud = Model.MakeClone();
            pointcloud.Matrix = registrationResult.Matrix;
            Logger.Debug("Coarse aligning...");
            registrationResult.Fitness = Registration.CoarseAligner.Apply(scene, pointcloud, Registration.CoarseAligner.GetSamples(Model));
            Logger.Debug("Coarse alignment error = " + registrationResult.Fitness.ToString("F3"));
            Logger.Debug("Fine aligning...");
            registrationResult.Fitness = Registration.FineAligner.Apply(scene, pointcloud, Registration.FineAligner.GetSamples(Model));
            Logger.Debug("Fine alignment error = " + registrationResult.Fitness.ToString("F3"));
            registrationResult.Matrix = pointcloud.Matrix;
            pointcloud.ApplyTransform();
            registrationResult.Overlap = pointcloud.CalcOverlap(scene, Registration.OverlapRadius, 4);
            Logger.Debug("Overlap rate = " + registrationResult.Overlap.ToString("F3"));
            registrationResult.FitnessOK = !check_fitness || registrationResult.Fitness <= Registration.MaxFitness;
            registrationResult.OverlapOK = !check_overlap || registrationResult.Overlap >= Registration.MinOverlap;
            registrationResult.LimitOK = !check_limit || Registration.ShiftLimit.IsInLimit(registrationResult.Matrix);
            registrationResult.Limit = Registration.ShiftLimit;
            registrationResult.MaxFitness = Registration.MaxFitness;
            registrationResult.MinOverlap = Registration.MinOverlap;
            Logger.Debug("FitnessOK = " + registrationResult.FitnessOK);
            Logger.Debug("OverlapOK= " + registrationResult.OverlapOK);
            Logger.Debug("LimitOK= " + registrationResult.LimitOK);
            registrationResult.Scene = scene;
            registrationResult.Aligned = pointcloud;
            return registrationResult;
        }

    }
}
