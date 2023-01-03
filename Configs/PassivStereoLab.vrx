<?xml version="1.0" encoding="UTF-8"?>
<MiddleVR>
	<Kernel Version="2.5.2.0" />
	<DeviceManager>
		<Driver Type="vrDriverDirectInput" />
	</DeviceManager>
	<DisplayManager WindowMode="0" AlwaysOnTop="1" Fullscreen="1" ShowMouseCursor="1" VSync="0" AntiAliasing="4" HDR="0" ForceHideTaskbar="0">
		<Node3D Name="SystemCenter" Parent="None" Tracker="0" PositionLocal="0.000000,0.000000,0.000000" OrientationLocal="0.000000,0.000000,0.000000,1.000000" IsFiltered="0" Filter="0" />
		<Node3D Name="HandNode" Parent="SystemCenter" Tracker="0" PositionLocal="0.000000,0.000000,0.000000" OrientationLocal="0.000000,0.000000,0.000000,1.000000" IsFiltered="0" Filter="0" />
		<Node3D Name="HeadNode" Parent="SystemCenter" Tracker="0" PositionLocal="0.000000,0.000000,0.000000" OrientationLocal="0.000000,0.000000,0.000000,1.000000" IsFiltered="0" Filter="0" />
		<CameraStereo Name="CameraStereo0" Parent="HeadNode" Tracker="0" PositionLocal="0.000000,0.000000,0.000000" OrientationLocal="0.000000,0.000000,0.000000,1.000000" IsFiltered="0" Filter="0" ICVFX="0" BackgroundResolutionMultiplier="1" IgnoreICVFX="0" RenderToTexture="0" Screen="0" Warper="0" VerticalFOV="60" Near="0.1" Far="1000" ScreenDistance="1" UseViewportAspectRatio="1" AspectRatio="1.33333" InterEyeDistance="0.065" LinkConvergence="1" />
		<Viewport Name="Viewport1" Left="0" Top="0" Width="3840" Height="2160" Camera="CameraStereo0.Left" ClusterNode="0" Stereo="0" StereoMode="3" CompressSideBySide="0" StereoInvertEyes="0" RenderToTextureCamera="0" UseCustomStereoCameras="0" CustomLeftBufferCamera="0" CustomRightBufferCamera="0" CornerOffsetTopLeftX="0" CornerOffsetTopLeftY="0" CornerOffsetTopRightX="0" CornerOffsetTopRightY="0" CornerOffsetBottomRightX="0" CornerOffsetBottomRightY="0" CornerOffsetBottomLeftX="0" CornerOffsetBottomLeftY="0" BlendingZoneLeft="0" BlendingZoneRight="0" BlendingZoneBottom="0" BlendingZoneTop="0" />
		<Viewport Name="Viewport2" Left="0" Top="0" Width="3840" Height="2160" Camera="CameraStereo0.Right" ClusterNode="0" Stereo="0" StereoMode="3" CompressSideBySide="0" StereoInvertEyes="0" RenderToTextureCamera="0" UseCustomStereoCameras="0" CustomLeftBufferCamera="0" CustomRightBufferCamera="0" CornerOffsetTopLeftX="0" CornerOffsetTopLeftY="0" CornerOffsetTopRightX="0" CornerOffsetTopRightY="0" CornerOffsetBottomRightX="0" CornerOffsetBottomRightY="0" CornerOffsetBottomLeftX="0" CornerOffsetBottomLeftY="0" BlendingZoneLeft="0" BlendingZoneRight="0" BlendingZoneBottom="0" BlendingZoneTop="0" />
	</DisplayManager>
	<Scripts>
		<Script Type="TrackerSimulatorKeyboard" Name="TrackerSimulatorKeyboard0" SensitivityX="1" SensitivityY="1" SensitivityZ="1" SensitivityYaw="1" SensitivityPitch="1" SensitivityRoll="1" />
	</Scripts>
	<ClusterManager NVidiaSwapLock="0" ServerUnityWindow="0" ClientConnectionTimeout="60" />
</MiddleVR>
