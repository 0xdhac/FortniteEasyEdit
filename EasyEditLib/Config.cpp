#include "stdafx.h"
#include "Config.h"
#include "Binds.h"

nlohmann::json Config::ConfigData;
std::string Config::ConfigPath;

bool Config::InitJson(std::string path)
{
	char dirPath[512];
	GetCurrentDirectoryA(512, dirPath);

	ConfigPath = dirPath + std::string("\\") + path;

	struct stat buffer;
	if ((stat(ConfigPath.c_str(), &buffer) != 0))
	{
		FILE* f;
		int err = fopen_s(&f, ConfigPath.c_str(), "w");

		if (err)
		{
			return false;
		}
		else
		{
			fclose(f);
			for (Bind* b : BindList)
			{
				ConfigData[b->m_Name] = b->m_vkCode;
			}
			SaveConfig();

			return true;
		}
	}
	else
	{
		std::fstream f(ConfigPath.c_str(), std::ios::in);
		f.seekg(0, std::ios_base::end);
		int length = (int)f.tellg();

		char* data = new char[length + 1];
		data[length] = '\0';
		f.seekg(0, std::ios_base::beg);
		f.read(data, length);

		ConfigData = nlohmann::json::parse(data);
		delete[] data;

		//FindBind("FakeEdit")->m_vkCode = 68;
		for (Bind* b : BindList)
		{
			if (ConfigData.find(b->m_Name) != ConfigData.end())
			{
				b->m_vkCode = ConfigData[b->m_Name];
			}
		}
		
		return true;
	}
}

void Config::SetValue(std::string key, int value)
{
	ConfigData[key] = value;
	SaveConfig();
}

void Config::SaveConfig()
{
	std::fstream f(ConfigPath.c_str(), std::ios::out | std::ios::trunc);
	f.clear();
	f.seekg(0, std::ios::beg);

	std::string s = ConfigData.dump();
	f.write(s.c_str(), s.size());
	f.close();
}
