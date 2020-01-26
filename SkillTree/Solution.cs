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
        int skill_trees_max = 20;

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

    public List<char> GetSkillList(char[] condition, string skill)
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

    public bool Checker(char[] condition, string skill)
    {
        if (condition.Empty == true || skill.Empty == true)
            return false;


        List<char> skillList = GetSkillList(condition, skill);
        
        //아예 없다.
        if (skillList.Count == 0)
            return true;

        for(int i = 0; skillList.Count; i++)
        {
            skillList[i];
        }

        return false;
    }

    
}
