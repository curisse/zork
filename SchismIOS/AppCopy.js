

import React, { useState } from 'react';
import { 
  TouchableWithoutFeedback, 
  StyleSheet,
  Button, 
  View, 
  SafeAreaView, 
  Image, 
  Text, 
  Alert,
  AppRegistry,
  TouchableNativeFeedback 
} from 'react-native';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';
import Navigator from './components/HomeStack';
import HomeBunchScreen from './components/index'


const Separator = () => (

  <View style={styles.separator} />
);

const App = () => {

  return (
  
  <NavigationContainer>

  <SafeAreaView style={styles.container}>

    <View>
    <Navigator />

    <Button
        title="about"
        color="blue"
        onPress={pressHandler}
      />

    </View>


    <View>

      

    <Image source={{
      height:200,
      width: 300,
      uri: "https://wallpaperaccess.com/full/3278792.jpg"
      }} />
        <Separator />
        
      <Text style={styles.title}>
      SCHISM
      </Text>

      <Text style={styles.title}>
      A journey in mind...
      </Text>
      <Separator />
    
      <Button
        title="start"
        color="red"
        onPress={() => 
          Alert.prompt('Enter your name', text => console.log(text))}
      />

    </View>

    <View>

    <Separator />

      <Button
        title="continue"
        color="green"
        onPress={() => Alert.alert('Button with adjusted color pressed')}
      />
    </View>

    <View>
    <Separator />
      <Button
        title="about"
        color="purple"
        onPress={() => Alert.alert('Button with adjusted color pressed')}
      />
    </View>
  
    <View>
    <Separator />
    <TouchableWithoutFeedback onPress={() => console.log("nice try, better luck next time...")}>
      <Button
        title="cheat"
        disabled
        onPress={() => Alert.alert('Cannot press this one')}
      />
    </TouchableWithoutFeedback>
    </View>
    
    <View>
      <Text style={styles.title}>
        built by aleks hammo
      </Text>
      <View style={styles.fixToText}>
        <Button
          title="Left button"
          onPress={() => Alert.alert('Left button pressed')}
        />
        <Button
          title="Right button"
          onPress={() => Alert.alert('Right button pressed')}
        />
      </View>
    </View>

  </SafeAreaView>

  </NavigationContainer>
  
  )};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    marginHorizontal: 16,
  },
  title: {
    textAlign: 'center',
    marginVertical: 8,
  },
  fixToText: {
    flexDirection: 'row',
    justifyContent: 'space-between',
  },
  separator: {
    marginVertical: 8,
    borderBottomColor: '#737373',
    borderBottomWidth: StyleSheet.hairlineWidth,
  },
  image: {
    width: 300,
    height: 400,
},
  }
);


export default App;