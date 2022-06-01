import React from "react";
import { NavigationContainer } from "@react-navigation/native";
import { createStackNavigator } from "react-navigation-stack";
import { createBottomTabNavigator } from "@react-navigation/bottom-tabs";


import {SignIn, CreateAccount, Profile, Home} from './Screens'

const AuthStack = createStackNavigator();
const Tabs = createBottomTabNavigator();
const HomeBunch = createStackNavigator();
const ProfileStack = createStackNavigator();
const SearchStack = createStackNavigator();

const HomeBunchScreen = () => (
    <HomeBunch.Navigator>
        <HomeBunch.Screen name="Home" component={Home} />
        <HomeBunch.Screen name="Details" component={Details} />
    </HomeBunch.Navigator>
)

// const ProfileStackScreen = () => (
//     <ProfileStack.Navigator>
//         <ProfileStack.Screen name="Home" component={Home} />
//     </ProfileStack.Navigator>
// )

const SearchStackScreen = () => (
    <SearchStack.Navigator>
        <SearchStack.Screen name="Search" component={Search} />
        <SearchStack.Screen name="Search2" component={Search2} />
    </SearchStack.Navigator>
)

export default () => (
    <NavigationContainer>
        <Tabs.Navigator>
            <Tabs.Screen name="Home" component={HomeBunchScreen} />
            <Tabs.Screen name="Profile" component={ProfileStackScreen} />
            <Tabs.Screen name="Profile" component={ProfileStackScreen} />
            

        </Tabs.Navigator>
        <AuthStack.Navigator>

            <AuthStack.Screen name="SignIn" component={SignIn} />
            <AuthStack.Screen name="CreateAccount" component={CreateAccount} />
            
        </AuthStack.Navigator>
    </NavigationContainer>
)