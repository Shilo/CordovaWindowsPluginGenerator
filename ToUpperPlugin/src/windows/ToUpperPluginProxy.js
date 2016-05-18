var cordova = require('cordova'),
    ToUpperPlugin= require('./ToUpperPlugin');

module.exports = {

    ToUpper: function (successCallback, errorCallback, strInput) {

        var upperCase = strInput[0].toUpperCase();
        if(upperCase != "") {
            successCallback(upperCase);
        }
        else {
            errorCallback(upperCase);
        }
    }
};

require("cordova/exec/proxy").add("ToUpperPlugin", module.exports);

