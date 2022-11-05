<?xml version="1.0" encoding="UTF-8"?>
<MiddleVR>
	<Kernel Version="2.5.2.0" />
	<DeviceManager>
		<Driver Type="vrDriverDirectInput" />
		<Wand Name="Wand0" Driver="0" Axis="Mouse.Axis" HorizontalAxis="0" HorizontalAxisScale="1" VerticalAxis="1" VerticalAxisScale="1" AxisDeadZone="0.3" Buttons="Mouse.Buttons" Button0="0" Button1="1" Button2="2" Button3="3" Button4="4" Button5="5" />
	</DeviceManager>
	<DisplayManager WindowMode="1" CompositorMode="0" AlwaysOnTop="1" Fullscreen="0" ShowMouseCursor="1" VSync="1" AntiAliasing="1" HDR="0" ForceHideTaskbar="0">
		<Node3D Name="SystemCenter" Parent="None" Tracker="0" PositionLocal="0.000000,0.000000,1.800000" OrientationLocal="0.000000,0.000000,0.000000,1.000000" IsFiltered="0" Filter="0" />
		<Node3D Name="HeadNode" Parent="SystemCenter" Tracker="TrackerSimulatorKeyboard0.Tracker" IsFiltered="0" Filter="0" UseTrackerX="1" UseTrackerY="1" UseTrackerZ="1" UseTrackerYaw="1" UseTrackerPitch="1" UseTrackerRoll="1" />
		<Camera Name="Camera0" Parent="HeadNode" Tracker="0" PositionLocal="-0.008467,0.000000,0.000000" OrientationLocal="0.000000,0.000000,0.000000,1.000000" IsFiltered="0" Filter="0" ICVFX="0" BackgroundResolutionMultiplier="1" IgnoreICVFX="0" RenderToTexture="0" Screen="0" Warper="0" VerticalFOV="77" Near="0.1" Far="1000" ScreenDistance="1" UseViewportAspectRatio="1" AspectRatio="1.33333" />
		<Node3D Name="HandNode" Parent="None" Tracker="0" PositionLocal="0.000000,0.000000,0.000000" OrientationLocal="0.000000,0.000000,0.000000,1.000000" IsFiltered="0" Filter="0" />
		<Viewport Name="Viewport0" Left="100" Top="100" Width="1060" Height="640" Camera="Camera0" ClusterNode="0" Stereo="0" StereoMode="3" CompressSideBySide="0" StereoInvertEyes="0" RenderToTextureCamera="0" UseCustomStereoCameras="0" CustomLeftBufferCamera="0" CustomRightBufferCamera="0" CornerOffsetTopLeftX="0" CornerOffsetTopLeftY="0" CornerOffsetTopRightX="0" CornerOffsetTopRightY="0" CornerOffsetBottomRightX="0" CornerOffsetBottomRightY="0" CornerOffsetBottomLeftX="0" CornerOffsetBottomLeftY="0" BlendingZoneLeft="0" BlendingZoneRight="0" BlendingZoneBottom="0" BlendingZoneTop="0" />
	</DisplayManager>
	<Scripts>
		<Script Type="TrackerSimulatorKeyboard" Name="TrackerSimulatorKeyboard0" SensitivityX="1" SensitivityY="1" SensitivityZ="1" SensitivityYaw="5" SensitivityPitch="5" SensitivityRoll="5" />
	</Scripts>
	<ClusterManager NVidiaSwapLock="0" ServerUnityWindow="0" ClientConnectionTimeout="60" />
</MiddleVR>
