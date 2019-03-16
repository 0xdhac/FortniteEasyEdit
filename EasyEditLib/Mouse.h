#pragma once

struct Mouse
{
	static void LeftClickHold();
	static void LeftClickRelease();
	static void LeftClick(DWORD holdDelayMS);
	static void RightClickHold();
	static void RightClickRelease();
	static void RightClick(DWORD holdDelayMS);
	static void Scroll(bool up);
};
