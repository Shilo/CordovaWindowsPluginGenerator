var cordova = require('cordova'),
    $PluginName$= require('./$PluginName$');

module.exports = {

    $MethodName$: function (successCallback, errorCallback, strInput) {

        var upperCase = strInput[0].toUpperCase();
        if(upperCase != "") {
            successCallback(upperCase);
        }
        else {
            errorCallback(upperCase);
        }
    }
};

require("cordova/exec/proxy").add("$PluginName$", module.exports);

