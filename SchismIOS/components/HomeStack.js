import { createStackNavigator } from "react-navigation-stack";
import { createAppContainer } from "react-navigation";
import HelloWorldApp from './HelloWorld';
import About from "./About";

const screens = 

{
    About: {
        screen: About
    },
    HelloWorld: {
        screen: HelloWorldApp
    },
    
}

const HomeStack = createStackNavigator(screens);

export default createAppContainer(HomeStack);