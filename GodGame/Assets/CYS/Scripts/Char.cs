using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character{
    public class Stat : MonoBehaviour //��� �� ����
    {
        public string charName;     //�̸�
        public int hp;              //����ü��
        public int maxhp;           //�ִ�ü��
        public int atk;             //���ݷ�
        public int ap;              //�ֹ���
        public int spd;             //�ӵ�
        public int equipmentCode;   //����ִ� ���
    }
    public class InputStat : MonoBehaviour  //�Է� �� ����
    {
        public string charName;     //�̸�
        public int hp;              //����ü��
        public int maxhp;           //�ִ�ü��
        public int atk;             //���ݷ�
        public int ap;              //�ֹ���
        public int spd;             //�ӵ�
        public int equipmentCode;   //����ִ� ���
    }
}
