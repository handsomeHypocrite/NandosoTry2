var getFood = (function () {
    // Return anything that you want to expose outside the closure
    return {
        foodList: function (callback) {
            // Code to make api calls goes here
            //console.log("this was called from student module");
            //console.log(privateVariable);

            $.ajax({
                type: "GET",
                dataType: "json",
                url: "http://nandosotry2.azurewebsites.net/api/Dishes",
                success: function (data) {
                    console.log(data);
                    callback(data);
                }

            });
        }
    };
}());