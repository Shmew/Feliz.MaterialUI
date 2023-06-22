var ghPages = require("gh-pages");

//var packageUrl = "https://github.com/Shmew/Feliz.MaterialUI.git";
var packageUrl = "https://github.com/ArtemyB/Feliz.MaterialUI.git";

console.log("Publishing to ", packageUrl);

ghPages.publish("deploy", {
    repo: packageUrl
}, function (e) {
    if (e === undefined) {
        console.log("Finished publishing succesfully");
    } else {
        console.log("Error occured while publishing :(", e);
    }
});
