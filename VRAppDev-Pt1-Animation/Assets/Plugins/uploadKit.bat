echo off
curl -v -b cookie -X PUT -F "kit[zip]=@C:\Users\Shadow\Documents\GitHub\VRAppDev-Pt1-Animation\AnimationAssignment\1727745535772721471_vrappdevm4.zip" -F "kit[game_engine_version]=20194" https://account.altvr.com/api/kits/1727745535772721471.json
