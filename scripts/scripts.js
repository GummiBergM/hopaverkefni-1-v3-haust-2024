function toggleMenu() {
  var menu = document.getElementById("menu");
  var hamburger = document.getElementById("hamburger");
  var cross = document.getElementById("cross");
  var nav = document.querySelector('nav');

  if (menu.style.display === "flex") {
    menu.style.display = "none"; // Hide the menu
    hamburger.style.opacity = "1"; // Show hamburger again
    hamburger.style.visibility = "visible"; 
    cross.style.opacity = "0"; // Hide cross
    cross.style.visibility = "hidden";
    cross.style.transform = "rotate(0deg)"; // Reset rotation
  } else {
    menu.style.display = "flex"; // Show the menu
    hamburger.style.opacity = "0"; // Hide hamburger
    hamburger.style.visibility = "hidden";
    cross.style.opacity = "1"; // Show cross
    cross.style.visibility = "visible";
    cross.style.transform = "rotate(90deg)"; // Rotate cross
    cross.style.transition = "transform 0.3s ease-in-out, opacity 0.3s ease-in-out"; // Smooth transition
  }
}