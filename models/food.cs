@model List<FoodHub.Models.Food>

@{
    ViewBag.Title = "Menu";
}

<h2>🍽️ Our Menu</h2>

<hr />

<div class="row">

    @foreach (var food in Model)
    {
        <div class="col-md-6">

            <div class="panel panel-default">

                <div class="panel-heading">

                    <h3>@food.Name</h3>

                </div>

                <div class="panel-body">

                    <p>
                        <b>Category:</b>
                        @food.Category
                    </p>

                    <p>
                        @food.Description
                    </p>

                    <h4>
                        ₹@food.Price
                    </h4>

                    <a href="@Url.Action("Details", "Menu",
                        new { id = food.Id })"
                       class="btn btn-primary">

                        View Details

                    </a>

                </div>

            </div>

        </div>
    }

</div>
