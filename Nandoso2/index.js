document.addEventListener("DOMContentLoaded", function () {
    console.log("DOM loaded and ready to go!");
    loadFood();
});

function loadFood() {
    
        //GetFood.getFood(setUpFoodTable);
    //console.log(StudentModule.pribateVariable);
    var FoodTable = document.getElementById("FoodList");
    getFood.foodList(function (FoodMenu) {
        setupFoodTable(FoodMenu)
    });

}

function setupFoodTable(dishes) {
    console.log(dishes);

    for (i = 0; i < dishes.length; i++) {
        var row = document.createElement('tr');

        var DishNameCol = document.createElement('td');
        DishNameCol.innerHTML = dishes[i].DishName;
        row.appendChild(DishNameCol);

        var DishPriceCol = document.createElement('td');
        DishPriceCol.innerHTML = dishes[i].Price;
        row.appendChild(DishPriceCol);

        var DishDescCol = document.createElement('td');
        DishDescCol.innerHTML = dishes[i].Describtion;
        row.appendChild(DishDescCol);


        FoodTable.appendChild(row);

    }


}