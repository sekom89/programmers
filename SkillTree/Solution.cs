using System;

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

    public int GetCoditionIndex(char[] condition, char c)
    {
        for (int i = 0; i < condition.Length; i++)
        {
            if (condition[i] == c)
            {
                return i;
            }
        }

        return -1;
    }

    public bool Checker(char[] condition, string skill)
    {
        if (condition.Empty == true || skill.Empty == true)
            return false;

        int conditionIndex = 0;
        int currentIndex = -1;
        for(int i = 0; i < skill.Length; i++)
        {
            currentIndex = GetCoditionIndex(skill[i]);
            if( currentIndex = conditionIndex)
            {
                conditionIndex++;
            }
        }

        if (conditionIndex > 0)
            return true;

        return false;
    }

    
}
