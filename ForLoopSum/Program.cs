﻿
int sum = 0;

for(int i = 1; i < 11; i++) {
    sum = sum + i; // sum += i; Siin real parem järjestus, konsoolis loogilisem tulemus
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
}

Console.WriteLine($"Final total {sum}");