#pragma once

#include <string>
#include <fstream>
#include "json.hpp"

namespace Config
{
	extern nlohmann::json ConfigData;
	extern std::string ConfigPath;
	bool InitJson(std::string path);
	void SetValue(std::string key, int value);
	void SaveConfig();
}