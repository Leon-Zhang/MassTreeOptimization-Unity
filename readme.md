Scene: hmstest-opt.unity
Optimization methods that conducted:
1. reduce field of view: 60 -> 36
2. PF CTI Windzone -> too many CTL_CustomWind scripts running and produce same effect as only one running, 
  disabled per-plane massive game objects, use only one PF CTI Windzone
3. Enable static occlusion culling

FPS improvement: 6FPS -> 120FPS


Scene: hmstest-mod.unity
Used an open source path generator and follower as base work, setup a custom path 
and makes camera follow.

![fps](hmstest-opt-fps.png)