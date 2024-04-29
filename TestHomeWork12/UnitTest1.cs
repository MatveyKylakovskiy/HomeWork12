using HomeWork12.FirstTask;
using System.Collections.Generic;

namespace TestHomeWork12
{
    public class UnitTest1
    {

        [Fact(DisplayName = "GetFirstOfString 1")]
        public void GetFirstOfStringTest1()
        {
            List<string> list = new List<string>() { "a", "b", "c", "d", "1ee", "2ee", "4ee", "4ee" };
            Assert.Equal("a", WorkerWithLINQ.GetFirstOfString(list));
        }

        [Fact(DisplayName = "GetFirstOfString 2")]
        public void GetFirstOfStringTest2()
        {
            List<string> list = new List<string>() { "aa", "b", "c", "d", "1ee", "2ee", "4ee", "4ee" };
            Assert.Equal("b", WorkerWithLINQ.GetFirstOfString(list));
        }

        [Fact(DisplayName = "GetFirstOfString 3")]
        public void GetFirstOfStringTest3()
        {
            List<string> list = new List<string>() { "aa", "bd", "cd", "dd", "1ee", "2ee", "4ee", "4ee" };
            Assert.Fail(WorkerWithLINQ.GetFirstOfString(list));
        }

        [Fact(DisplayName = "GetFirstOfString 4")]
        public void GetFirstOfStringTest4()
        {
            List<string> list = new List<string>() { "aa", "bd", "cd", "dd", "1ee", "2ee", "4ee", "e" };
            Assert.Equal("e", WorkerWithLINQ.GetFirstOfString(list));
        }

        //
        
        [Theory(DisplayName = "GetLastConteinEE")]
        [MemberData(nameof(Data2))]
        public void GetLastConteinEETest(List<string> list, string expected)
        {
            Assert.Equal(expected, WorkerWithLINQ.GetLastContainEE(list));
        }

        [Theory(DisplayName = "Should find string in list")]
        [MemberData(nameof(Data1))] 
        public void ShouldFindStringInList(List<string> list, string expected)
        {
            Assert.Equal(expected, WorkerWithLINQ.GetFirstOfString(list));
        }



        public static IEnumerable<object[]> Data1() {
            yield return new object[]
            {
                new List<string> { "a", "bd", "cd", "dd", "1ee1", "2ee1", "4ee1", "ee" },
                "a"
            };

            yield return new object[]
            {
                new List<string> { "b", "d", "cd", "dd", "1ee1", "2ee1", "4ee1", "ee" },
                "b"
            };

            yield return new object[]
            {
                new List<string> { "dd", "dd", "cd", "dd", "1ee1", "2ee1", "4ee1", "ee" },
                "b"
            };
        }

        public static IEnumerable<object[]> Data2()
        {
            yield return new object[]
            {
                new List<string> { "ee", "bd", "cd", "dd", "1ee1", "2ee1", "4ee1", "2ee" },
                "2ee"
            };

            yield return new object[]
            {
                new List<string> { "b", "d", "cd", "dd", "1ee1ee", "2ee1", "4ee1", "2eeg" },
                "1ee1ee"
            };

            yield return new object[]
            {
                new List<string> { "dd", "dd", "cd", "dd", "1ee1", "2ee1", "4ee1", "eee3" },
                null
            };
        }
    }
}





/*

����������� ��������� ������:

����� ���������� ������ ����� �� ������������������ ����, ����������
������ ���� �����.

�����, ������������ ��������� �����, ���������� � ���� ��������� ���.
�����������, ��������� ������ 1 ����� LINQ.

����������� ����� ��� �������� ���������� �����, ���������������� �������:
����� ����� �� ������ min � �� ������ max. ���� ��� ����, ���������������
�������, ����� ���������� null.

�������� �����, ������� ���������� ���������� ���������� �������� �
�������.

�������� �����, ������� ��������� ������ � ��������� �������� �� 5
(������������) �������������� �� �������� ��, ������� �������� ����� "3"

����� ���������� ����� ������ ��������� �����

�������� �����, ������� ����������� ������� � ������ � ������ �������
������ ���� � ��������*/

