using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for https://programmers.co.kr/learn/courses/30/lessons/49993
/// </summary>
public class Solution
{
    public int solution(string skill, string[] skill_trees)
    {
        int answer = 0;

        char[] condition = SkillToCondition(skill);

        for(int i = 0; i < skill_trees.Length; ++i)
        {
            if(Checker(condition, skill_trees[i]))
            {
                answer++;
            }
        }

        return answer;
    }

    public char[] SkillToCondition(string skill)
    {
        if (skill.Empty == true)
            return null;

        char[] condition = new char[skill.Length];

        for (int i= 0; i< skill.Length; i++)
        {
            condition[i] = skill[i];
        }

        return condition;
    }

    public bool Checker(char[] condition, string skill)
    {
        if (condition.Empty == true || skill.Empty == true)
            return false;


        List<char> skillList = GetRefineList(condition, skill);

        //아예 없다.
        if (skillList.Count == 0)
            return true;

        //reverse
        for (int i = skillList.Count - 1; i = 0; i--)
        {
            char _condition = GetCondition(skillList[i]);

            //first
            if (_condition == null)
                continue;

            if (i == 0)
                break;

            if(_condition != skillList[i - 1])
            {
                return false;   
            }
        }

        return true;
    }

    public List<char> GetRefineList(char[] condition, string skill)
    {
        List<char> tree = new List<char>();

        for (int i = 0; i < skill.Length; i++)
        {
            for(int k = 0; k < condition.Length; k++)
            {
                if(condition[k] == skill[i])
                {
                    tree.Add(skill[i]);
                    break;
                }
            }
        }

        return tree;
    }

    public char GetCondition(char[] condition, char skill)
    {
        for (int k = 0; k < condition.Length; k++)
        {
            if (condition[k] == skill)
            {
                if(k == 0)
                {
                    return null;
                }

                return condition[k - 1];
            }
        }

        return null;
    }
}
