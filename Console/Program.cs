using MediatorPattern;
using MementoPattern;
using ObservePattern;
using ObservePattern.ObserveTargets;
using StatePattern;
using StrategyPattern;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using IteratorPattern;
using ProxyPattern;
using VisitorPattern;
using VisitorPattern.Visitor;
using ResponsibilityChainPattern;
using BridgePattern.Server;
using BridgePattern.Service;

namespace PatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============状态模式=================");
            ShowStatePattern();//状态模式
            Console.WriteLine("===============策略模式=================");
            ShowStrategyPattern(State.State3, "2");//策略模式
            Console.WriteLine("==============访问者模式================");
            ShowVisitorPattern();//访问者模式
            Console.WriteLine("============原始观察者模式==============");
            ShowObservePattern();//原始观察者模式
            Console.WriteLine("=======基于C#事件实现观察者模式==========");
            ShowObservePattern2();//基于C#事件实现观察者模式
            Console.WriteLine("==============备忘录模式================");
            ShowMementoPattern();//备忘录模式
            Console.WriteLine("==============中介者模式================");
            ShowMediatorPattern();//中介者模式
            Console.WriteLine("==============迭代器模式================");
            ShowIteratorPattern();//迭代器模式
            Console.WriteLine("===============代理模式=================");
            ShowProxyPattern();//代理模式
            Console.WriteLine("==============责任链模式================");
            ShowResPonsibilityChainPattern();//责任链模式
            Console.WriteLine("===============桥接模式=================");
            ShowBridgePattern();//桥接模式
            Console.ReadLine();
        }

        static void ShowStatePattern()
        {
            StateContext stateContext = new StateContext
            {
                StateBase = new StateThree()
            };
            for (int i = 0; i < 5; i++)
            {
                stateContext.ShowState();
                stateContext.NextState();
            }
        }
        static void ShowStrategyPattern(State eParam, string sParam)
        {
            StrategyContext stateContext = new StrategyContext();
            StrategyBase strategyBase = null;
            switch (eParam)
            {
                case State.State1:
                    strategyBase = new StrategyOne();
                    break;
                case State.State2:
                    strategyBase = new StrategyTwo();
                    break;
                case State.State3:
                    strategyBase = new StrategyThree();
                    break;
                default:
                    throw new Exception("int参数只能是1，2，3");
            }
            strategyBase.Invoke(eParam, sParam);//可以这么做，但这样就不能额外做一些其他的操作了
            stateContext.Invoke(eParam, sParam, strategyBase);
        }
        static void ShowVisitorPattern()
        {
            List<BallBase> ballBases = new List<BallBase>()
            {
                new BasketBall(),
                new BasketBall(),
                new FootBall(),
                new BasketBall(),
                new FootBall()
            };
            BallVisitorBase oldVisitor = new OldVisitor();
            foreach (var ball in ballBases)
            {
                ball.Play(oldVisitor);
            }
            Console.WriteLine("=========================================");
            BallVisitorBase newVisitor = new NewVisitor();
            foreach (var ball in ballBases)
            {
                ball.Play(newVisitor);
            }
        }
        static void ShowObservePattern()
        {
            Observe observe = new Observe();
            observe.AddObserveItem(() => new Computer().Calc(1, 2));
            observe.AddObserveItem(new Keyboard().Enter);
            observe.AddObserveItem(new Mouse().Click);
            observe.ObserveAction();
        }
        static void ShowObservePattern2()
        {
            ObserveEvent observe = new ObserveEvent();
            observe.ObserveEventSource += () => new Computer().Calc(1, 2);
            observe.ObserveEventSource += new Keyboard().Enter;
            observe.ObserveEventSource += new Mouse().Click;
            observe.RaiseEvent();
        }
        static void ShowMementoPattern()
        {
            Area area = new Area()
            {
                AreaName = "温州市",
                Lng = "120",
                Lat = "28",
                CreateTime = DateTime.Now.ToString("s")
            };
            Console.WriteLine(string.Join(',', area.GetType().GetProperties().Select(x => $"{x.Name}:{x.GetValue(area)}")));
            area.Save("温州");//设置备忘
            area = new Area()
            {
                AreaName = "杭州市",
                Lng = "28",
                Lat = "120",
                CreateTime = DateTime.Now.ToString("s")
            };
            Console.WriteLine(string.Join(',', area.GetType().GetProperties().Select(x => $"{x.Name}:{x.GetValue(area)}")));
            area.ReLoad("温州");//属性值被修改了，希望能恢复之前的数值
            Console.WriteLine(string.Join(',', area.GetType().GetProperties().Select(x => $"{x.Name}:{x.GetValue(area)}")));
        }
        static void ShowMediatorPattern()
        {
            Console.WriteLine("customerA购买");
            Customer customerA = new Customer();
            Console.WriteLine("注意商品价格的变化");
            customerA.Shopping(20, 10, 10);
            Console.WriteLine("customerB购买");
            Customer customerB = new Customer();
            customerB.Shopping(13, 24, 15);
            Console.WriteLine("customerC购买");
            Customer customerC = new Customer();
            customerC.Shopping(2, 40, 33);
            Console.WriteLine($"==================家电数量最便宜 游戏机最便宜 天猫水果最便宜==================");
        }
        static void ShowIteratorPattern()
        {
            Iterator<string> iterator = new Iterator<string>(new[] { "a", "b", "c" });
            var enumrator = (iterator as IEnumerable).GetEnumerator();//使用接口实现方法需要先转换成接口
            while (enumrator.MoveNext())
            {
                //按需加载
                Console.WriteLine(enumrator.Current);
            }
            foreach (var item in iterator as IEnumerable)
            {
                //按需加载
                Console.WriteLine(item);
            }
            foreach (var item in iterator)
            {
                //一次性加载
                Console.WriteLine(item);
            }
        }

        static void ShowProxyPattern()
        {
            GameLevelingProxy gameLevelingProxy = new GameLevelingProxy();
            gameLevelingProxy.Play();
        }


        static void ShowResPonsibilityChainPattern()
        {
            int num = new Random().Next(0, 500);
            StepOne stepOne = new StepOne();
            StepTwo stepTwo = new StepTwo();
            StepThree stepThree = new StepThree();
            stepOne.SetNextStep(stepTwo);
            stepTwo.SetNextStep(stepThree);
            stepOne.InvokeHandle(new StepContext() { Number = num });
        }

        static void ShowBridgePattern()
        {
            ISevice uploadSevice = new UploadSevice()
            {
                Vision = "1.1"
            };
            ISevice cacheSevice = new CacheSevice()
            {
                Vision = "1.2"
            };
            ISevice downloadSevice = new DownloadSevice()
            {
                Vision = "1.0"
            };
            ISevice sourceSevice = new SourceSevice()
            {
                Vision = "2.1"
            };
            ISevice transpondSevice = new TranspondSevice()
            {
                Vision = "1.3"
            };
            CommomServer commomServer = new CommomServer();
            {
                commomServer.Service = uploadSevice;
                commomServer.Call();
            }
            {
                commomServer.Service = cacheSevice;
                commomServer.Call();
            }
            {
                commomServer.Service = downloadSevice;
                commomServer.Call();
            }
            {
                commomServer.Service = sourceSevice;
                commomServer.Call();
            }
            {
                commomServer.Service = transpondSevice;
                commomServer.Call();
            }
        }
    }
}
