using System;
namespace Exercicio {
    class SetimoProjeto {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro números inteiros. Descubra a diferença entre os dois primeiros e os dois últimos:");
            string[] v_nums = Console.ReadLine().Split(' ');
            float num_1 = float.Parse(v_nums[0]);
            float num_2 = float.Parse(v_nums[1]);
            float num_3 = float.Parse(v_nums[2]);
            float num_4 = float.Parse(v_nums[3]);
            float dif_nums1 = num_1 - num_2;
            float dif_nums2 = num_3 - num_4;
            float dif_nums3 = dif_nums1 - dif_nums2;
            Console.WriteLine($"O valor da diferença entre os números primeiros mencionados é de: {dif_nums1}");
            Console.WriteLine($"O valor da diferença entre os números primeiros mencionados é de: {dif_nums2}");
            Console.WriteLine($"O valor da diferença das diferenças é de: {dif_nums3}");
        }
    }
}