using System;
namespace Quest
{
    class Quest1
    {
        static void Main(string[] args)
        {
            int Layers;
            int Choice1;
            bool result;
            
            string[] MenuMeat = { "#0Говядина", "#1Баранина", "#2Курица", "#3Свинина", "#4Пенчекряк" };
            string[] MenuFish = { "#0Форель", "#1Карась", "#2Окунь", "#3Акула", "#4Шпагук" };
            string[] MenuPlants = { "#0Шпинат", "#1Томаты", "#2Огурцы", "#3Морская капуста", "#4Реска" };
            string[] MenuGems = { "#0Вяленые кораллы", "#1Трюфели", "#2Жемчужный лук", "#3Мраморная говядина", "#4Брют" };
            
            Console.WriteLine("Добро пожаловать в пиццерию 'Толстый Лякуша'");
            Console.WriteLine("Пожалуйста, выберите количество слоев в вашей пицце. (Не более пяти!)");

            Layers = int.Parse(Console.ReadLine());
            
            string[] Pizza = new string[Layers];

            for (int i = 0, j,z = 0; i < Layers; i++,z++)
            {
                Console.WriteLine("Пожалуйста, выберите тип ингриентов для вашей пиццы. (Доступные типы ингридиентов: #1Мясо, #2Рыба, #3Зелень, #4Экзотика)");

                j = int.Parse(Console.ReadLine());

                switch (j)
                {
                    case 1:
                        {
                            Console.WriteLine("Мясное меню:");

                            for (int k = 0; k < MenuMeat.Length; k++)
                            {
                                Console.WriteLine(MenuMeat[k]);
                            }

                                Console.WriteLine("Выберите ингридиент.");

                                Choice1 = int.Parse(Console.ReadLine());

                                    for (int a = 0; a < Layers; a++)
                                    {
                                        result = String.Equals(MenuMeat[Choice1], Pizza[a]);

                                    if (result)
                                        {
                                            z--;
                                        }
                                    }

                            if (i == z)
                            {
                                Pizza[i] = MenuMeat[Choice1];
                            }
                            else
                            {
                                Console.WriteLine("Ингридиенты не должны повторяться!");
                                
                                i--;
                            }
                            
                            break;
                                
                        }
                    case 2:
                        {
                            Console.WriteLine("Рыбное меню:");

                            for (int k = 0; k < MenuFish.Length; k++)
                            {
                                Console.WriteLine(MenuFish[k]);
                            }

                                Console.WriteLine("Выберите ингридиент.");

                                Choice1 = int.Parse(Console.ReadLine());

                                for (int a = 0; a < Layers; a++)
                                {
                                    result = String.Equals(MenuFish[Choice1], Pizza[a]);

                                if (result)
                                    {
                                        z--;
                                    }
                                }

                                if (i == z)
                                {
                                    Pizza[i] = MenuFish[Choice1];
                                }
                                else
                                {
                                    Console.WriteLine("Ингридиенты не должны повторяться!");

                                    i--;
                                }

                            
                            
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("Растительное меню:");

                            for (int k = 0; k < MenuPlants.Length; k++)
                            {
                                Console.WriteLine(MenuPlants[k]);
                            }

                            Console.WriteLine("Выберите ингридиент.");

                            Choice1 = int.Parse(Console.ReadLine());

                                for (int a = 0; a < Layers; a++)
                                {
                                   result = String.Equals(MenuPlants[Choice1], Pizza[a]);

                                if (result)
                                    {
                                        z--;
                                    }
                                }

                                if (i == z)
                                {
                                    Pizza[i] = MenuPlants[Choice1];
                                }
                                else
                                {
                                    Console.WriteLine("Ингридиенты не должны повторяться!");

                                    i--;
                                }
 
                            break;

                        }
                    case 4:
                        {
                            Console.WriteLine("Экзотическое меню:");

                            for (int k = 0; k < MenuGems.Length; k++)
                            {
                                Console.WriteLine(MenuGems[k]);
                            }

                            Console.WriteLine("Выберите ингридиент.");

                            Choice1 = int.Parse(Console.ReadLine());

                                for (int a = 0; a < Layers; a++)
                                {
                                    result = String.Equals(MenuGems[Choice1], Pizza[a]);

                                    if (result)
                                    {
                                        z--;
                                    }
                                }

                                if (i == z)
                                {
                                    Pizza[i] = MenuGems[Choice1];
                                }
                                else
                                {
                                    Console.WriteLine("Ингридиенты не должны повторяться!");

                                    i--;
                                }

                            break;
                        }
                }
            }
            Console.WriteLine("Ваша пицца:");
            for (int i = 0; i < Pizza.Length; i++)
            {
                Console.WriteLine(Pizza[i]);
            }            
        }
    }
}