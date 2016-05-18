var $PluginName$ = {
    $MethodName$: function (successCallback, errorCallback, strInput) {
        cordova.exec(successCallback, errorCallback, "$PluginName$", "$MethodName$", [strInput]);
    }
}

module.exports = $PluginName$;
