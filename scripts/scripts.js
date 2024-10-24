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

document.addEventListener("DOMContentLoaded", function () {
  const fadeElements = document.querySelectorAll('.fade-in');

  function handleScroll() {
    fadeElements.forEach(el => {
      const rect = el.getBoundingClientRect();
      if (rect.top <= window.innerHeight - 50) { // Trigger slightly before the element is fully in view
        el.classList.add('show');
      }
    });
  }

  window.addEventListener('scroll', handleScroll);

  // Trigger the function initially in case some elements are already in view on page load
  handleScroll();
});