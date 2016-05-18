var ToUpperPlugin = {
    ToUpper: function (successCallback, errorCallback, strInput) {
        cordova.exec(successCallback, errorCallback, "ToUpperPlugin", "ToUpper", [strInput]);
    }
}

module.exports = ToUpperPlugin;
