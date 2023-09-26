// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    const images = document.querySelectorAll('.carousel img');
    let currentIndex = 0;

    function showImage(index) {
        images.forEach((image, i) => {
            if (i === index) {
                image.style.display = 'block';
            } else {
                image.style.display = 'none';
            }
        });
    }

    function nextImage() {
        currentIndex = (currentIndex + 1) % images.length;
        showImage(currentIndex);
    }

    // Mostrar la primera imagen
    showImage(currentIndex);

    // Cambiar de imagen automáticamente cada 3 segundos (3000 milisegundos)
    setInterval(nextImage, 3000);
});

