using LotusAPI;
using LotusAPI.MV;
using LotusAPI.Robotics;
using System;
using System.Threading.Tasks;
using Img = LotusAPI.MV.Image;

namespace ATMC.App.MultiRobotBolting {
    internal class MyUtils {
        //Scan and convert to CC
        internal static Pointcloud Scan(RobotPoseEx[] in_poses, out RobotPoseEx[] out_poses, out Img[] scene_imgs) {
            Pointcloud scene = null;
            var poses = in_poses == null ? new RobotPoseEx[Global.ROBOT_COUNT] : in_poses;
            var clouds = new Pointcloud[Global.SCANNER_COUNT];
            var imgs = new Img[Global.SCANNER_COUNT];

            bool read_pose = (in_poses == null);
            out_poses = poses;
            scene_imgs = imgs;

            try {
                for(int i = 0; i < clouds.Length; i++) {
                    clouds[i] = null;
                    if (Global.EnableS(i)) Global.Scanners.AssertScannerConnected(i);
                    if (Global.EnableR(i)) {
                        if(read_pose) {
                            poses[i] = null;
                            Global.Robots.AssertRobotConnected(i);
                        }
                    }
                }

                //Scan all
                Task[] tasks = new Task[clouds.Length];
                for(int i = 0; i < clouds.Length; i++) {
                    int tid = i;
                    tasks[tid] = Task.Run(delegate {
                        if(Global.EnableS(tid)) {
                            clouds[tid] = Global.Scanners[tid].Scan();
                            imgs[tid] = clouds[tid].ShadeImage;
                            Logger.Debug($"Point count [{i}] = {clouds[tid].ValidVertexCount()}");
                        }
                        if (Global.EnableR(tid) && read_pose) poses[tid] = Global.Robots[tid].GetCurrentPose();
                    });
                }

                Task.WaitAll(tasks);

                //check cloud validity
                for(int i = 0; i < clouds.Length; i++) {
                    if(Global.EnableS(i)) {
                        if(clouds[i] == null || clouds[i].Count < Global.Setting.MinPointCount)
                            throw new Exception($"Cloud({i}) is invalid");
                        //convert to CC
                        clouds[i] = Global.HandEyes[i].EyeToCC(clouds[i], poses[i].Matrix);
                    }
                }

                //combine non-null
                scene = Pointcloud.Combine(Array.FindAll(clouds, x => x != null));
                Logger.Debug($"Total point count = {scene.ValidVertexCount()}");
                out_poses = poses;
                scene_imgs = imgs;
                return scene;
            } catch(Exception ex) {
                Logger.Error(ex.Message);
            }
            return null;
        }
    }
}
