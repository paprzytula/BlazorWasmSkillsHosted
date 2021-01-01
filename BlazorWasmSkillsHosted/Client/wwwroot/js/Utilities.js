function myfunction(message) {
    console.log("from utilities " + message);
}
function dotnetStaticInvokation() {
    DotNet.invokeMethodAsync("BlazorWasmSkillsHosted.Client", "GetCurrentCount")
        .then(result => {
            console.log("count from JavaScript " + result)
        });
}
function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}