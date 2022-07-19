using ChainOfResponsibility;
using ChainOfResponsibility.Models.BaseClasses;
using FacadaPattern.Models.BaseClasses;

Human human = new User("jerry", "jerry@jerry.com", "jerry12345");

CheckerDirector director = new CheckerDirector();

director.MakeHumanChecker(human);