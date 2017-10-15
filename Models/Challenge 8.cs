<!-- Challenge 9 (Set Up Create Quest and Quest Details Links) -->

@model List<ForgingAhead.Models.Quest>
<h1>
 Quests
</h1>
<p>
 <a asp-action="Create" asp-controller="Quest">Create new quest</a>
<p>
<ul>
 @foreach(var item in Model)
 {
   <li>
     <a asp-action="Details" asp-controller="Quest" asp-route-name="@item.Name">@item.Name</a>
   </li>
 }
</ul>
