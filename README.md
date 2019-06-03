
# react-native-ussd-dial

![npm](https://img.shields.io/npm/v/react-native-ussd-dial.svg)
![npm bundle size](https://img.shields.io/bundlephobia/min/react-native-ussd-dial.svg)

## Getting started

`$ npm install react-native-ussd-dial --save`

### Mostly automatic installation

`$ react-native link react-native-ussd-dial`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-ussd-dial` and add `RNUssdDial.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNUssdDial.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNUssdDialPackage;` to the imports at the top of the file
  - Add `new RNUssdDialPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-ussd-dial'
  	project(':react-native-ussd-dial').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-ussd-dial/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-ussd-dial')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNUssdDial.sln` in `node_modules/react-native-ussd-dial/windows/RNUssdDial.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Ussd.Dial.RNUssdDial;` to the usings at the top of the file
  - Add `new RNUssdDialPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNUssdDial from 'react-native-ussd-dial';

// TODO: What to do with the module?
RNUssdDial;
```
  