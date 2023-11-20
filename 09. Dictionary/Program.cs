﻿using System.Collections;

namespace _09._Dictionary
{
    internal class Program
    {
        /******************************************************
        * 해시테이블 (HashTable)
        * 
        * 키 값을 해시함수로 해싱하여 해시테이블의 특정 위치로 직접 엑세스하도록 만든 방식
        * 해시 : 임의의 길이를 가진 데이터를 고정된 길이를 가진 데이터로 매핑
        ******************************************************/

        // <해시테이블의 시간복잡도>
        // 접근			탐색			삽입			삭제
        // X			O(1)		O(1)		O(1)

        // <해시함수의 조건>
        // 입력에 대한 해시함수의 결과가 항상 동일한 값이어야 함

        // <해시함수의 효율>
        // 1. 해시함수의 처리속도가 빠를수록 효율이 좋음
        // 2. 해시함수의 결과가 밀집도가 낮아야 함
        // 3. 해시테이블의 크기가 클수록 빠르지만 메모리가 부담됨

        // <해시테이블 주의점 - 충돌>
        // 해시함수가 서로 다른 입력 값에 대해 동일한 해시테이블 주소를 반환하는 것
        // 모든 입력 값에 대해 고유한 해시 값을 만드는 것은 불가능하며 충돌은 피할 수 없음
        // 대표적인 충돌 해결방안으로 체이닝과 개방주소법이 있음

        // <충돌해결방안 - 체이닝>
        // 해시 충돌이 발생하면 연결리스트로 데이터들을 연결하는 방식
        // 장점 : 해시테이블에 자료가 많아지더라도 성능저하가 적음
        // 단점 : 해시테이블 외 추가적인 저장공간이 필요

        // <충돌해결방안 - 개방주소법>
        // 해시 충돌이 발생하면 다른 빈 공간에 데이터를 삽입하는 방식
        // 해시 충돌시 선형탐색, 제곱탐색, 이중해시 등을 통해 다른 빈 공간을 선정
        // 장점 : 추가적인 저장공간이 필요하지 않음, 삽입삭제시 오버헤드가 적음
        // 단점 : 해시테이블에 자료가 많아질수록 성능저하가 많음
        // 해시테이블의 공간 사용률이 높을 경우 성능저하가 발생하므로 재해싱 과정을 진행함
        // 재해싱 : 해시테이블의 크기를 늘리고 테이블 내의 모든 데이터를 다시 해싱 

        public class Monster
        {
            public string name;

            public Monster(string name)
            {
                this.name = name;
            }
        }

        public static void Test()
        {

            Hashtable ht = new Hashtable();
            ht.Add("파이리", new Monster("파이리"));
            ht.Add(123, true);
            ht.Add(3.2f, "문자열");
            
            Monster pairy = (Monster)ht["파이리"];
            // bool b = (bool)ht(123);
            // string str = (string)ht(3.2f);

            HashSet<Monster> set = new HashSet<Monster>();
            set.Add(new Monster("파이리"));
            set.Add(new Monster("꼬부기"));
            
            HashSet<int> set2 = new HashSet<int>();
            set2.Add(1);
            set2.Add(2);

            Dictionary<string, Monster> dic = new Dictionary<string, Monster>();
            dic.Add("파이리", new Monster("파이리"));
            dic.Add("꼬부기", new Monster("꼬부기"));
            dic.Add("이상해씨", new Monster("이상해씨"));

            Monster d = dic["파이리"];

            dic.TryGetValue("파이리", out Monster m1);

            Console.WriteLine("{0}, {1}", d.name, m1.name);

            dic.Remove("파이리");
        }

        static void Main(string[] args)
        {
            Test();
        }
    }
}