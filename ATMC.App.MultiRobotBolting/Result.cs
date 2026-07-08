using ATMC.Common;
using LotusAPI;
using LotusAPI.Robotics;
using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace ATMC.App.MultiRobotBolting {
    [JsonSerializable]
    public class Result : ResultBase {
        public RegistrationResult RegistationResult { get; set; } = null;
        public int TryCount { get; set; } = 0;
        public Result(ModelConfig model) : base(model, Global.Setting.ResultDir) { }

        public override void SaveDB() {
            try {
                Logger.Log($"[{Model.Name}] Inserting DB record...");
                var row = DB.MyTable.NewRow();
                row[DB.COL.DATE] = DateTime.Now;
                row[DB.COL.MODEL] = Model.Name;
                row[DB.COL.BODY_NO] = BodyNo;
                row[DB.COL.SEQ_NO] = SeqNo;
                row[DB.COL.RESULT] = OK ? "OK" : "NG";

                if(RegistationResult != null) {
                    row[DB.COL.FIT] = (float)RegistationResult.Fitness;
                    row[DB.COL.OVL] = (float)RegistationResult.Overlap;
                    var pose = new RobotPose(RegistationResult.Matrix);
                    row[DB.COL.DX] = (float)pose.X;
                    row[DB.COL.DY] = (float)pose.Y;
                    row[DB.COL.DZ] = (float)pose.Z;
                    row[DB.COL.DRX] = (float)pose.Rx;
                    row[DB.COL.DRY] = (float)pose.Ry;
                    row[DB.COL.DRZ] = (float)pose.Rz;
                }

                var offset = (Model as ModelConfig).Registration.ShiftOffset;
                row[DB.COL.OX] = (float)offset.DX;
                row[DB.COL.OY] = (float)offset.DY;
                row[DB.COL.OZ] = (float)offset.DZ;
                row[DB.COL.ORX] = (float)offset.DRx;
                row[DB.COL.ORY] = (float)offset.DRy;
                row[DB.COL.ORZ] = (float)offset.DRz;

                row[DB.COL.RESULT_DIR] = GetResultDir();
                DB.MyTable.InsertRow(row);
                Logger.Log($"OK");
            } catch(Exception ex) {
                Logger.Error(ex.Message);
                Logger.Trace(ex.StackTrace);
            }
            try {
                string DBName = $"hmgma_ga_bat_on";
                using (var con = new MySqlConnection($"Server={Global.Setting.DBServerAddress};Uid=atmc;Pwd=atmc")) {
                    con.Open();

                    using (var cmd = con.CreateCommand()) {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText =
                            $"CREATE DATABASE IF NOT EXISTS `{DBName}` " +
                            "CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;";
                        cmd.ExecuteNonQuery();
                    }

                    con.ChangeDatabase(DBName);

                    using (var cmd = con.CreateCommand()) {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 30;
                        cmd.CommandText =
                            "CREATE TABLE IF NOT EXISTS `" + DBName + "`.`tblcycleinfo` (" +
                            "  `CycleID`    INT AUTO_INCREMENT PRIMARY KEY," +
                            "  `DATE`       VARCHAR(300)," +
                            "  `MODEL`      VARCHAR(16)," +
                            "  `BODY_NO`    VARCHAR(32)," +
                            "  `SEQ_NO`     VARCHAR(16)," +
                            "  `RESULT`     CHAR(2)," +
                            "  `FIT`        FLOAT," +
                            "  `OVL`        FLOAT," +
                            "  `DX`         FLOAT, `DY` FLOAT, `DZ` FLOAT," +
                            "  `DRX`        FLOAT, `DRY` FLOAT, `DRZ` FLOAT," +
                            "  `OX`         FLOAT, `OY` FLOAT, `OZ` FLOAT," +
                            "  `ORX`        FLOAT, `ORY` FLOAT, `ORZ` FLOAT," +
                            "  `RESULT_DIR` VARCHAR(300)" +
                            ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;";
                        cmd.ExecuteNonQuery();
                    }

                    using (var cmd = con.CreateCommand()) {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 5;
                        StringBuilder sb = new StringBuilder();

                        sb.Append($"INSERT INTO `{DBName}`.`tblcycleinfo` SET ");
                        sb.Append($"`DATE` = '{DateTime.Now}', ");
                        sb.Append($"`MODEL` = '{Model.ID}', ");
                        sb.Append($"`BODY_NO` = '{BodyNo}', ");
                        sb.Append($"`SEQ_NO` = '{SeqNo}', ");
                        sb.Append($"`RESULT` = '{(OK ? "OK" : "NG")}', ");

                        sb.Append($"`FIT` = {(float)RegistationResult.Fitness}, ");
                        sb.Append($"`OVL` = {(float)RegistationResult.Overlap}, ");
                        var pose = new RobotPose(RegistationResult.Matrix);
                        sb.Append($"`DX`  = {(float)pose.X}, ");
                        sb.Append($"`DY`  = {(float)pose.Y}, ");
                        sb.Append($"`DZ`  = {(float)pose.Z}, ");
                        sb.Append($"`DRX` = {(float)pose.Rx}, ");
                        sb.Append($"`DRY` = {(float)pose.Ry}, ");
                        sb.Append($"`DRZ` = {(float)pose.Rz}, ");

                        var offset = (Model as ModelConfig).Registration.ShiftOffset;
                        sb.Append($"`OX`  = {(float)offset.DX}, ");
                        sb.Append($"`OY`  = {(float)offset.DY}, ");
                        sb.Append($"`OZ`  = {(float)offset.DZ}, ");
                        sb.Append($"`ORX` = {(float)offset.DRx}, ");
                        sb.Append($"`ORY` = {(float)offset.DRy}, ");
                        sb.Append($"`ORZ` = {(float)offset.DRz}, ");

                        sb.Append($"`RESULT_DIR`   = '{GetResultDir()}'");
                        cmd.CommandText = sb.ToString();
                        cmd.ExecuteNonQuery();
                    }
                    Logger.Log($"OK (MariaDB)");
                }
            }
            catch (Exception ex) {
                Logger.Error(ex.Message);
                Logger.Trace(ex.StackTrace);
            }

        }

        //Save result
        public override void Save(string prefix = "") {
            base.Save();
            RegistationResult.Save(GetResultDir(prefix), "", "cc");
        }
    }
}
