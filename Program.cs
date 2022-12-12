/*
 * Created by SharpDevelop.
 * User: HP8440P
 * Date: 12.12.2022
 * Time: 12:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SmartStorage
{
	class Program
	{
		public static void Main(string[] args)
		{
			class MainCore{
				bool newTask; // наличие новых задач
				int PlatformId1; // порядковый номер тележки в данном примере таких переменных 3 для каждой тележки по одной штуке
				int PlatformId2; 
				int PlatformId3; 
				bool isBusy1; // флаг занятости тележки в данном примере таких переменных 3 для каждой тележки по одной штуке
				bool isBusy2;
				bool isBusy3;
				int busyCount1; // счетчик работ выполненных тележкой в данном примере таких переменных 3 для каждой тележки по одной штуке
				int busyCount2;
				int busyCount3;
				into controllerBusyness // состояния контроллера
				switch ( controllerBusyness )
				{ 	
					case 0: // контроллер свободен
					if (newTask = true )
					{	
					controllerBusyness == 1;
					newTask == false; 
					}
					break; 
					case 1: // контролер задал задачу тележке n
					if ( isBool1 = false ) 
					{
					busyCount1 == 1;
					isBool1 == true;
					}
					else if ( busyCount1>busyCount2 and isBool2 = false ) 
					{
					busyCount2 == 1;
					isBool2 == true;
					}
					else if ( busyCount2>busyCount3 and isBool3 = false ) 
					{
					busyCount3 == 1;
					isBool3 == true;
					}
					else if ( busyCount1=busyCount2=busyCount3 )
					{
					busyCount1 == 0;
					busyCount2 == 0;
					busyCount3 == 0;
					isBool1 == true;
					}
					else if ( isBool1=isBool2=isBool3=true )
					{
					controllerBusyness == 2;
					}
					break; 
					case 2: // контроллер не имеет свободных тележек ( режим ожидания )
					wait 100;
					controllerBusyness == 1;
					break; 
				}
			}
			
			class AutoPlatform{
				int relay; // реле управления может принимать следующие значения 0 – поворот налево, 1 – езда прямо, 2 – поворот направо
				int videoSensor; //видео датчик принимает четыре основных значения 0 – линия слева, 1 – линия посередине, 2 – линия справа, 3 – линия утеряна, сравнивает имеющийся маршрут с полученным из контроллера значением
				int lineSensor1; //датчик обнаружения белой линии левый
				int lineSensor2; //датчик обнаружения белой линии средний
				int lineSensor3; //датчик обнаружения белой линии правый
				int platformState; //
				bool cargoReady; //груз загружен
				bool cargoEmpty; //груз снят
				bool engineStart; //двигатель запущен
				bool turnRelay; //реле поворота включено
				bool chargeMore40; //заряд выше 40%
				bool chargeLess40; //заряд ниже 40%
				bool roadIsEmpty; //дорога свободна
				bool roadObstacle; //на дороге препятствие 
				bool alternativeWay; //альтернативный маршрут 
				bool mainWay; //основной маршрут
				bool noDirectives; //задач нет
				bool newDirectives; //задачи есть
				bool chargerSwitchOn; //зарядка подключена
				bool chargerSwitchOff; //зарядка отключена
				bool chargeFull; заряд полный
				
				switch ( platformState )
				{
					case 0 : //двигатель не запущен
					cargoReady = false;
					cargoEmpty = false; 
					engineStart = false;
					turnRelay = false;
					chargeMore40;
					if ( chargeLess40 )
					{
					platformState ==2;
					}
					roadIsEmpty = false;
					roadObstacle = false;
					alternativeWay = false;
					mainWay = false;
					noDirectives = true;
					newDirectives = false;
					chargerSwitchOn = false;
					chargerSwitchOff = false;
					chargeFull = false;
					break; 
					case 1: //движение 
					cargoReady = true;
					cargoEmpty = false; 
					engineStart = true;
					turnRelay = true;
					chargeMore40;
					if ( chargeLess40 == true) 
					{
					chargerSwitchOn = true;
					chargerSwitchOff = false;
					chargeFull = false;
					platformState ==2;
					}
					if (roadIsEmpty == false) 
					{
					chargerSwitchOn = true;
					chargerSwitchOff = false;
					chargeFull = false;
					platformState ==2;
					}
					if ( roadObstacle == true; )
					{
					chargerSwitchOn = true;
					chargerSwitchOff = false;
					chargeFull = false;
					platformState ==2;
					}
					if ( mainWay == false;) 
					{
					alternativeWay == true;
					platformState ==3;
					}
					noDirectives = false;
					newDirectives = true;
					break; 
					case 2://зарядка
					if ( chargeFull == true;) 
					{
					if ( newDirectives == true; )
					{
					platformState == 1;
					}
					else if ( noDirectives == true) 
					{
					platformState == 2;
					}
					}
					break;
					case 3://объезд препятствия
					alternativeWay = true;
				break;
			}
			
			class Store{
				bool platformStart; // команда на выдвижение получена
				bool WtoS; // сигнализация свободного пути при движении вперед
				bool platformMove; //сигнализация загрузки или разгрузки платформы на стеллаже
				bool platformBack; // команда на возвращение на базу получена
				bool WtoB; // сигнализация свободного пути при движении назад
				bool WintoS; // сигнализация свободного пути при движении по складу 
				
				switch ( platformWay )
				{
					case 0: // тележка x на базе и ждет дальнейших команд
					if ( platformStart == true ) 
					{
					platformWay = 1;
					platformStart = false; 
					}
					break; 
					case 1: // тележка x едет к стеллажу y по пути № t
					if ( WtoS == false) 
					{
					platformWay = 2;
					}
					else if ( WtoS == true ) 
					{
					platformWay = 3;
					}
					break;
					case 2: // тележка x объезжает препятствие на секторе a через узел b
					if ( WtoS == false) 
					{
					platformWay = 2;
					}
					else if ( WtoS == true ) 
					{
					platformWay = 1;
					}
					break; 
					case 3: // тележка x разгружается или загружается
					if ( platformMove == true ) 
					{
					platformWay = 4;
					}
					else if ( platformBack == true) 
					{
					platformWay = 6;
					}
					break; 
					case 4: // тележка x едет к стеллажу z по маршруту c
					if ( WintoS == false ) 
					{
					platformWay = 5;
					}
					else if ( WintoS == true ) 
					{
					platformWay = 6;
					}
					break;
					case 5: // тележка x объезжает препятствие на секторе d через узел e
					if ( WintoS == false ) 
					{
					platformWay = 5;
					}
					else if ( WintoS == true ) 
					{
					platformWay = 4;
					}
					break;
					case 6: // тележка x едет на базу по маршруту № t
					if ( WtoB == false ) 
					{
					platformWay = 7;
					}
					else if ( WtoB == true ) 
					{
					platformWay = 0;
					}
					break;
					case 7: // тележка x объезжает препятствие на секторе f через узел g
					if ( WtoB == false ) 
					{
					platformWay = 7;
					}
					else if ( WtoB == true ) 
					{
					platformWay = 4;
					}
					break;
				}	
			}
			
			
			}
			/*
			  * 
			  * 
			  * 
			  * Данный код педоставлен в ознакомительных целях, для конкетного внедрения на определенной системе удет нужна доработка под потребноси этой системы.
			  * This code is provided in acquittal purposes, for a particular implementation on a certain system, refinement will be needed for the need of this system.
			  * 
			  * 
			  * 
			  * */
		}
	}
}