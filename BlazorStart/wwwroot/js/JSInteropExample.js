window.exampleJSFunctions = {

    showPrompt: function (text) {
        return prompt(text, 'Type your name here');
    },

    displayWelcome: function (welcomeMessage) {
        document.getElementById('welcome').innerText = welcomeMessage;
    },

    showAlert: function () {
        alert('Hello from JS');
    },

    sayHelloCallerJS: function () {
        DotNet.invokeMethodAsync('BlazorStart', 'SayHello', 'Blazor presentation');
}

};