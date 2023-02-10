// //Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] nums = new int[8];

for (int i = 0; i<8; i++) {
    Console.Write("Enter number " +  (i + 1) + ": ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}
Console.Write("[");

for (int i = 0; i<nums.Length; i++) {
    Console.Write(nums[i] + ", ");
}
Console.Write("]");
