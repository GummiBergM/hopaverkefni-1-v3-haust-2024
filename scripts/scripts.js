function toggleMenu() {
    var menu = document.getElementById("menu");
    var hamburger = document.getElementById("hamburger");
    var cross = document.getElementById("cross");

    if (menu.style.display === "flex") {
      menu.style.display = "none"; // Hide the menu
      hamburger.style.display = "flex"; // Show the hamburger
      cross.style.display = "none"; // Hide the cross
    } else {
      menu.style.display = "flex"; // Show the menu
      hamburger.style.display = "none"; // Hide the hamburger
      cross.style.display = "flex"; // Show the cross
    }
}