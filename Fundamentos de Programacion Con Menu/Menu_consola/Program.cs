namespace Menu_consola
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opc = 0;

            do
            {
                try
                {
                    //Menu principal
                    Console.Clear();
                    Console.WriteLine("\t\t\t-------Bienvenido-------\n\t\t\t----------MENU----------\n");
                    Console.WriteLine("\t\t1. Calculadora.\t\t3. Calcular INSS e IR.");
                    Console.WriteLine("\t\t2. Arreglos.\t\t4. Salir.\n");
                    Console.Write("\n\t\tSeleccione su opción: ");

                    opc = Convert.ToInt32(Console.ReadLine());

                    //Opciones
                    switch (opc)
                    {
                        case 1:
                            Calculadora();
                            break;

                        case 2:
                            Arreglo();
                            break;

                        case 3:
                            CalculoInss();
                            break;

                        case 4:
                            Console.WriteLine("\n\n\t\tHa salido del programa.\n\t\tHasta pronto");
                            return;

                        default:
                            Console.WriteLine("\n\n\t\tOpción incorrecta.");
                            break;
                    }
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("\n\n\t\tOpción incorrecta.");
                    Console.ReadLine();
                }
            } while (opc != 4); //Fin bucle
        } //Fin Main

        public static void Calculadora()
        {
            int opc1 = 0;
            int c;
            double a, b, residuo;
            double resultado = 0, resultado2 = 0, resultado3 = 0, resultado4 = 0, resultado5 = 0;
            do
            {
                try
                {
                    //Menu calculadora
                    Console.Clear();
                    Console.WriteLine("\t\t\t-------Bienvenido-------\n\t\t\t----------MENU----------");
                    Console.WriteLine("\t\t\t-------Calculadora------\n\n");
                    Console.WriteLine("\t\t1. Suma.\t\t4. Multiplicación.");
                    Console.WriteLine("\t\t2. Resta.\t\t5. División.");
                    Console.WriteLine("\t\t3. Raíz cuadrada.\t6. Salir.\n");
                    Console.Write("\n\t\tSeleccione su opción: ");

                    opc1 = Convert.ToInt32(Console.ReadLine());

                    switch (opc1)
                    {
                        case 1: //Suma

                            Console.Clear();
                            Console.WriteLine("\n\t\t\t-------Suma-------\n");
                            Console.Write("\n\tDigite la cantidad de numeros a sumar: ");
                            c = Convert.ToInt32(Console.ReadLine()); //Cantidad de numeros que se suman
                            double[] numeros = new double[c]; //Arreglo para los numeros que digite el usuario

                            for (int i = 0; i < c; i++) //para recorrer el arreglo, guardar y sumar numeros
                            {
                                Console.Write("\n\tDigite el " + (i + 1) + "°" + " número: ");
                                numeros[i] = Convert.ToDouble(Console.ReadLine()); //Guardar numeros en arreglo
                                resultado += numeros[i]; //Sumar
                            }
                            Console.WriteLine("\n\n\tEl resultado es: " + resultado); //Resultado

                            break;

                        case 2: //Resta

                            Console.Clear();
                            Console.WriteLine("\n\t\t\t-------Resta-------\n");
                            Console.Write("\n\tDigite la cantidad de numeros a restar: ");
                            c = Convert.ToInt32(Console.ReadLine()); //Cantidad de numeros que se restan
                            double[] numeros2 = new double[c]; //Arreglo para los numeros que digite el usuario

                            for (int i = 0; i < c; i++) //para recorrer el arreglo y guardar
                            {
                                Console.Write("\n\tDigite el " + (i + 1) + "°" + " número: ");
                                numeros2[i] = Convert.ToDouble(Console.ReadLine()); //Guardar numeros en arreglo
                                if (i == 0) //condicion para guardar el primer valor del arreglo cuando cuando esta en la posicion 0
                                {
                                    resultado2 = numeros2[i]; //primer valor
                                }
                                else //resta de el valor viejo con el nuevo
                                {
                                    resultado2 -= numeros2[i];
                                }

                            }
                        Console.WriteLine("\n\n\tEl resultado es: " + resultado2); //Resultado
                    
                        break;

                        case 3: //Raiz cuadrada

                            Console.Clear();
                            Console.WriteLine("\n\t\t\t-------Raíz Cuadrada-------\n");
                            Console.Write("\n\tDigite la cantidad de numeros para sacar la raíz: ");
                            c = Convert.ToInt32(Console.ReadLine()); //Cantidad de numeros que se saca raiz
                            double[] numeros3 = new double[c]; //Arreglo para los numeros que digite el usuario

                            for (int i = 0; i < c; i++) //para recorrer el arreglo, guardar
                            {
                                Console.Write("\n\tDigite el " + (i + 1) + "°" + " número: ");
                                numeros3[i] = Convert.ToDouble(Console.ReadLine()); //Guardar numeros en arreglo
                            }
                            Console.WriteLine("\n");
                            for (int i = 0; i < c; i++) //Sacar raiz cuadrada de forma individual y mostrar el resultado
                            {
                                resultado3 = Math.Sqrt(numeros3[i]); //raiz cuadrada
                                Console.WriteLine("\tEl resultado " + (i+1) + " es: " + resultado3); //Resultado
                                resultado3 = 0; //reiniciar el resultado para que no cause conflicto
                            }

                            break;

                        case 4: //Multiplicacion
                            Console.Clear();
                            Console.WriteLine("\n\t\t\t-------Multiplicación-------\n");
                            Console.Write("\n\tDigite la cantidad de numeros a multiplicar: ");
                            c = Convert.ToInt32(Console.ReadLine()); //Cantidad de numeros que se multiplican
                            double[] numeros4 = new double[c]; //Arreglo para los numeros que digite el usuario

                            for (int i = 0; i < c; i++) //para recorrer el arreglo, guardar y multiplicar numeros
                            {
                                Console.Write("\n\tDigite el " + (i + 1) + "°" + " número: ");
                                numeros4[i] = Convert.ToDouble(Console.ReadLine()); //Guardar numeros en arreglo
                                if (i == 0) //condicion para no tener resultado 0
                                {
                                    resultado4 = numeros4[i]; //asignar el primer valor al resultado y no multiplicarlo con 0
                                }
                                else
                                {
                                    resultado4 = numeros4[i] * resultado4; //multiplicar el numero viejo con el nuevo
                                }
                                
                            }
                            Console.WriteLine("\n\n\tEl resultado es: " + resultado4); //Resultado

                            break;

                        case 5: //División
                            Console.Clear();
                            Console.WriteLine("\n\t\t\t-------División-------\n");
                            Console.Write("\n\tDigita el valor del dividendo: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\n\tDigita el valor del divisor: ");
                            b = Convert.ToDouble(Console.ReadLine());

                            if (b == 0)
                            {
                                Console.WriteLine("\n\tForma indeterminada.");
                                Console.WriteLine("\n\tEl divisor no puede ser igual a 0");
                            }
                            else
                            {
                                resultado5 = a / b;
                                residuo = a % b;

                                Console.WriteLine("\n\tEl cociente es: " + resultado5);
                                Console.WriteLine("\n\tEl residuo es: " + residuo);
                            }
                            
                            break;

                        case 6:
                            Console.WriteLine("\n\n\t\t\tHa salido de la calculadora.\n\t\t\tPresione ENTER.");
                            return;

                        default:
                            Console.WriteLine("\n\n\t\t\tOpción incorrecta.");
                            break;
                    }

                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("\n\n\t\t\tOpción incorrecta.");
                    Console.ReadLine();
                }

            }while (opc1 != 6); //Fin bucle

        } //Fin metodo calculadora

        public static void Arreglo()
        {
            int c1; //tamaño del arreglo
            double aux; //auxiliar para sustituir valores del arreglo

            try
            {
                //Menu Arreglo
                Console.Clear();
                Console.WriteLine("\t\t\t-------Bienvenido-------\n\t\t\t----------MENU----------");
                Console.WriteLine("\t\t\t--------Arreglos--------\n\n");

                Console.Write("\tDigite la cantidad que desee del arreglo: ");
                c1 = Convert.ToInt32(Console.ReadLine()); //tamaño del arreglo
                double[] arreglo = new double[c1]; //arreglo

                for (int j = 0; j < c1; j++) //ciclo para digitar los numeros en el arreglo
                {
                    Console.Write("\n\tDigita el " + (j + 1) + "° número: ");
                    arreglo[j] = Convert.ToDouble(Console.ReadLine()); //guardar numeros en arreglo
                }
                Console.Clear();
                Console.Write("\n\n\tOrden de digitación:\n\t");
                for (int k = 0; k < c1; k++) //mostrar orden de usuario
                {
                    Console.Write(arreglo[k] + ", ");
                }

                for (int i = 0; i < c1; i++) //orden descendente
                {
                    for (int j = i + 1; j < c1; j++)
                    {
                        if (arreglo[i] < arreglo[j])
                        {
                            aux = arreglo[i];
                            arreglo[i] = arreglo[j];
                            arreglo[j] = aux; 
                        }
                    }
                }
                Console.Write("\n\n\tOrden descendente:\n\t");
                for(int i = 0; i < c1; i++)
                {
                    Console.Write(arreglo[i] + ", ");
                }

                for (int i = 0; i < c1; i++) //orden ascendente
                {
                    for (int j = i + 1; j < c1; j++)
                    {
                        if (arreglo[i] > arreglo[j])
                        {
                            aux = arreglo[i];
                            arreglo[i] = arreglo[j];
                            arreglo[j] = aux;
                        }
                    }
                }
                Console.Write("\n\n\tOrden ascendente:\n\t");
                for (int i = 0; i < c1; i++)
                {
                    Console.Write(arreglo[i] + ", ");
                }


            }
            catch (Exception)
            {
                Console.WriteLine("\n\tHa digitado un valor incorrecto");
            }

        } //Fin metodo arreglo

        public static void CalculoInss()
        {
            int opc2=0;
            double salarioBruto = 0;
            double mult = 0;
            double ImpBase;
            double porctAplicable;
            double baseimponible = 0;
            double sobreecx;
            double mult2 = 0;
            double resta = 0;
            double app = 0;
            double suma = 0;
            double div = 0;
            double SNM = 0;
            
            
                try
                {
                    Console.Clear();
                    Console.WriteLine("\t---Calculadora de Impuestos del INSS e IR----");
                    Console.WriteLine("     --------------------------------------------------");
                    Console.WriteLine("\t1)INSS");
                    Console.WriteLine("\t2)IR");
                    Console.WriteLine("\t3)Ver estado Completo");
                    Console.WriteLine("\t4)Salir");
                    Console.Write("\n\t\tSeleccione su opción: ");

                    opc2 = Convert.ToInt32(Console.ReadLine());

                    
                    switch (opc2)
                    {
                        case 1:

                            Console.Write("\nDigite su salario bruto en C$ ");
                            salarioBruto = Convert.ToInt32(Console.ReadLine());
                            mult = salarioBruto * 0.07;//calculando la tase de inss que es el 7%

                            baseimponible = salarioBruto - mult;//calculando la base imponible salario-valor del INss

                            mult2 = baseimponible * 12;//Calculando la expectativa anual que es base imponible * 12

                            Console.Clear();
                            Console.WriteLine("\t-----Muestra De Datos---------");
                            Console.WriteLine("\n\tRenta Mensual ----- " + "C$" + salarioBruto);
                            Console.WriteLine("\n\tINNS laboral 7%----" + "C$ " + mult);
                            Console.WriteLine("\n\tBase Imponible----" + "C$ " + baseimponible);
                            Console.WriteLine("\n\tExpectativa Mensual---" + "C$ " + mult2);


                            if (mult2 <= 100000)
                            {
                                ImpBase = 0;
                                porctAplicable = 0;
                                sobreecx = 0;
                                Console.WriteLine("\n\tNo tendra ningun impuesto en su salario");
                                break;
                            }
                            if (mult2 > 10000 && mult2 <= 200000)
                            {
                                ImpBase = 0;
                                porctAplicable = 0.15;
                                sobreecx = 100000;
                                resta = mult2 - sobreecx;
                                Console.WriteLine("\n\tEl Exceso Aplicado es de----" + "C$" + sobreecx);
                                Console.WriteLine("\n\tSalario con SobreExceso---" + "C$" + resta);
                                break;
                            }
                            if (mult2 > 200000 && mult2 <= 350000)
                            {
                                ImpBase = 15000;
                                porctAplicable = 0.2;
                                sobreecx = 200000;
                                resta = mult2 - sobreecx;
                            Console.WriteLine("\n\tEl Exceso Aplicado es de----" + "C$" + sobreecx);
                            Console.WriteLine("\n\tSalario con SobreExceso---" + "C$" + resta);

                            break;
                            }
                            if (mult2 > 350000 && mult2 <= 500000)
                            {
                                ImpBase = 45000;
                                porctAplicable = 0.25;
                                sobreecx = 350000;
                                resta = mult2 - sobreecx;
                             Console.WriteLine("\n\tEl Exceso Aplicado es de----" + "C$" + sobreecx);
                             Console.WriteLine("\n\tSalario con SobreExceso---" + "C$" + resta);


                            break;
                            }
                            if (mult2 > 500000)
                            {
                                ImpBase = 82000;
                                porctAplicable = 0.3;
                                sobreecx = 500000;
                                resta = mult2 - sobreecx;
                             Console.WriteLine("\n\tEl Exceso Aplicado es de----" + "C$" + sobreecx);
                             Console.WriteLine("\n\tSalario con SobreExceso---" + "C$" + resta);
                            break;

                            }

                            break;

                        /////////////////////////////////////////////////////////////
                        case 2:
                         Console.Write("\nDigite su salario bruto en C$ ");
                         salarioBruto = Convert.ToInt32(Console.ReadLine());

                        mult = salarioBruto * 0.07;//calculando la tase de inss que es el 7%

                        baseimponible = salarioBruto - mult;//calculando la base imponible salario-valor del INss

                        mult2 = baseimponible * 12;//Calculando la expectativa anual que es base imponible * 12

                        Console.Clear();
                        if (mult2 <= 100000)
                        {
                            ImpBase = 0;
                            porctAplicable = 0;
                            sobreecx = 0;
                            Console.WriteLine("\n\tNo tendra ningun impuesto  en su salario");
                            break;
                        }
                        if (mult2 > 10000 && mult2 <= 200000)
                        {
                            ImpBase = 0;
                            porctAplicable = 0.15;
                            sobreecx = 100000;
                            resta = mult2 - sobreecx;
                            app = resta * porctAplicable;
                            suma = app + ImpBase;
                            Console.WriteLine("\n\tSu porcentaje aplicable es de--------" + "C$" + app);
                            Console.WriteLine("\n\tNo Tendra ningun Impuesto base");
                            Console.WriteLine("\n\tSu salario no posee IR");
                           
                            break;
                        }
                        if (mult2 > 200000 && mult2 <= 350000)
                        {
                            ImpBase = 15000;
                            porctAplicable = 0.2;
                            sobreecx = 200000;
                            resta = mult2 - sobreecx;
                            app = resta * porctAplicable;
                            suma = app + ImpBase;
                            div = suma / 12;

                            SNM = salarioBruto - mult - div;
                            Console.WriteLine("\n\tSu porcentaje aplicable es de----" + "C$" + app);
                            Console.WriteLine("\n\tSu impuesto base es de----" + "C$" + ImpBase);
                            Console.WriteLine("\n\tSu IR anual es de-----" + "C$" + suma);
                            Console.WriteLine("\n\tSu IR mensual es de---"+"C${0:N2}",div);
                            Console.WriteLine("\n\tSu salario neto mensual es de---" + "C${0:N2}" ,SNM);
                            break;
                        }
                        if (mult2 > 350000 && mult2 <= 500000)
                        {
                            ImpBase = 45000;
                            porctAplicable = 0.25;
                            sobreecx = 350000;
                            resta = mult2 - sobreecx;
                            app = resta * porctAplicable;
                            suma = app + ImpBase;
                            div = suma / 12;
                            SNM = salarioBruto - mult - div;
                            Console.WriteLine("\n\tSu porcentaje aplicable es de----" + "C$" + app);
                            Console.WriteLine("\n\tSu impuesto base es de----" + "C$" + ImpBase);
                            Console.WriteLine("\n\tSU IR anual es de-----" + "C$" + suma);
                            Console.WriteLine("\n\t U IR mensual es de---" + "C${0:N2}" , div);
                            Console.WriteLine("\n\tSu salario neto mensual es de---" + "C${0:N2}" , SNM);


                            break;
                        }
                        if (mult2 > 500000)
                        {
                            ImpBase = 82000;
                            porctAplicable = 0.3;
                            sobreecx = 500000;
                            resta = mult2 - sobreecx;
                            app = resta * porctAplicable;
                            suma = app + ImpBase;
                            div = suma / 12;
                            SNM = salarioBruto - mult - div;
                            Console.WriteLine("\n\tSu porcentaje aplicable es de----" + "C$" + app);
                            Console.WriteLine("\n\tSu impuesto base es de----" + "C$" + ImpBase);
                            Console.WriteLine("\n\tSU IR anual es de-----" + "C$" + suma);
                            Console.WriteLine("\n\t U IR mensual es de---" + "C${0:N2}" , div);
                            Console.WriteLine("\n\tSu salario neto mensual es de---" + "C${0:N2}" , SNM);
                            break;

                        }
                        break;

                        //////////////////////////////////////////////////////////
                        case 3:
                        Console.Write("\nDigite su salario bruto en C$ ");
                        salarioBruto = Convert.ToInt32(Console.ReadLine());
                        mult = salarioBruto * 0.07;//calculando la tase de inss que es el 7%

                        baseimponible = salarioBruto - mult;//calculando la base imponible salario-valor del INss

                        mult2 = baseimponible * 12;//Calculando la expectativa anual que es base imponible * 12

                        Console.Clear();
                        Console.WriteLine("\t-----Muestra De Datos---------");
                        Console.WriteLine("\n\tRenta Mensual ----- " + "C$" + salarioBruto);
                        Console.WriteLine("\n\tINNS laboral 7%----" + "C$ " + mult);
                        Console.WriteLine("\n\tBase Imponible----" + "C$ " + baseimponible);
                        Console.WriteLine("\n\tExpectativa Mensual---" + "C$ " + mult2);
                        if (mult2 <= 100000)
                        {
                            ImpBase = 0;
                            porctAplicable = 0;
                            sobreecx = 0;
                            Console.WriteLine("No tendra ningun impuesto  en su salario");
                            break;
                        }
                        if (mult2 > 10000 && mult2 <= 200000)
                        {
                            ImpBase = 0;
                            porctAplicable = 0.15;
                            sobreecx = 100000;
                            resta = mult2 - sobreecx;
                            app = resta * porctAplicable;
                            Console.WriteLine("\n\tEl Exceso Aplicado es de----" + "C$" + sobreecx);
                            Console.WriteLine("\n\tSalario con SobreExceso---" + "C$" + resta);
                            Console.WriteLine("\n\tSu porcentaje aplicable es de--------" + "C$" + app);
                            Console.WriteLine("\n\tNo Tendra ningun Impuesto base");
                            Console.WriteLine("\n\tSu salario no posee IR");
                            break;
                        }
                        if (mult2 > 200000 && mult2 <= 350000)
                        {
                            ImpBase = 15000;
                            porctAplicable = 0.2;
                            sobreecx = 200000;
                            resta = mult2 - sobreecx;
                            app = resta * porctAplicable;
                            suma = app + ImpBase;
                            div = suma / 12;
                            SNM = salarioBruto - mult - div;
                            Console.WriteLine("\n\tEl Exceso Aplicado es de----" + "C$" + sobreecx);
                            Console.WriteLine("\n\tSalario con SobreExceso---" + "C$" + resta);
                            Console.WriteLine("\n\tSu porcentaje aplicable es de----" + "C$" + app);
                            Console.WriteLine("\n\tSu impuesto base es de----" + "C$" + ImpBase);
                            Console.WriteLine("\n\tSu IR anual es de-----" + "C$" + suma);
                            Console.WriteLine("\n\tSu IR mensual es de---" + "C${0:N2}" , div);
                            Console.WriteLine("\n\tSu salario neto mensual es de---" + "C${0:N2}" , SNM);

                            break;
                        }
                        if (mult2 > 350000 && mult2 <= 500000)
                        {
                            ImpBase = 45000;
                            porctAplicable = 0.25;
                            sobreecx = 350000;
                            resta = mult2 - sobreecx;
                            app = resta * porctAplicable;
                            suma = app + ImpBase;
                            div = suma / 12;
                            SNM = salarioBruto - mult - div;
                            Console.WriteLine("\n\tEl Exceso Aplicado es de----" + "C$" + sobreecx);
                            Console.WriteLine("\n\tSalario con SobreExceso---" + "C$" + resta);
                            Console.WriteLine("\n\tSu porcentaje aplicable es de----" + "C$" + app);
                            Console.WriteLine("\n\tSu impuesto base es de----" + "C$" + ImpBase);
                            Console.WriteLine("\n\tSu IR anual es de-----" + "C$" + suma);
                            Console.WriteLine("\n\tSu IR mensual es de---" + "C${0:N2}" , div);
                            Console.WriteLine("\n\tSu salario neto mensual es de---" + "C${0:N2}" , SNM);


                            break;
                        }
                        if (mult2 > 500000)
                        {
                            ImpBase = 82000;
                            porctAplicable = 0.3;
                            sobreecx = 500000;
                            resta = mult2 - sobreecx;
                            app = resta * porctAplicable;
                            suma = app + ImpBase;
                            div = suma / 12;
                            SNM = salarioBruto - mult - div;
                            Console.WriteLine("\n\tEl Exceso Aplicado es de----" + "C$" + sobreecx);
                            Console.WriteLine("\n\tSalario con SobreExceso---" + "C$" + resta);
                            Console.WriteLine("\n\tSu porcentaje aplicable es de----" + "C$" + app);
                            Console.WriteLine("\n\tSu impuesto base es de----" + "C$" + ImpBase);
                            Console.WriteLine("\n\tSu IR anual es de-----" + "C$" + suma);
                            Console.WriteLine("\n\tSu IR mensual es de---" + "C${0:N2}" , div);
                            Console.WriteLine("\n\tSu salario neto mensual es de---" + "C${0:N2}" , SNM);
                            break;

                        }


                        break;

                        case 4:
                            Console.WriteLine("ADIOS");
                            break;

                        default:
                            Console.WriteLine("\n\n\t\tOpción incorrecta.");
                            break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Error");

                }

           
                

           
        }//Fin Metodo Calcular Inss

    } //Fin class
} //Fin namespace