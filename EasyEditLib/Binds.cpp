#include "stdafx.h"
#include "Binds.h"

std::vector<Bind*> BindList;

void RegisterBind(Bind* bind)
{
	BindList.push_back(bind);
}

unsigned int FindAndSetKeyDownOnBind(int hookType, int wParam, int vkCode)
{
	unsigned int bindsSet = 0;

	for(Bind* b : BindList)
	{
		if (b->m_HookType == hookType && b->m_wParam == wParam && b->m_vkCode == vkCode)
		{
			b->m_bKeyDown = true;
			bindsSet++;
		}
	}

	return bindsSet;
}

Bind* FindBind(std::string name)
{
	for (Bind* b : BindList)
	{
		if (b->m_Name.compare(name) == 0)
		{
			return b;
		}
	}

	return nullptr;
}

Bind::Bind(std::string name, std::string displayName, int hookType, int wParam, int vkCode, std::string description):
	m_Name(name), m_DisplayName(displayName), m_HookType(hookType), m_wParam(wParam), m_vkCode(vkCode), m_Description(description), m_bKeyDown(false) {};
