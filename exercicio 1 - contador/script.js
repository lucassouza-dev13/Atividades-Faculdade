let contador = 0;

const numero = document.getElementById("numero");

document.getElementById("incrementar").addEventListener("click", function() {
  contador++;
  numero.textContent = contador;

  if (contador > 0) {
    numero.style.color = "green";
  } else if (contador < 0) {
    numero.style.color = "red";
  } else {
    numero.style.color = "black";
  }
});

document.getElementById("decrementar").addEventListener("click", function() {
  contador--;
  numero.textContent = contador;

  if (contador > 0) {
    numero.style.color = "green";
  } else if (contador < 0) {
    numero.style.color = "red";
  } else {
    numero.style.color = "black";
  }
});

document.getElementById("zerar").addEventListener("click", function() {
  contador = 0;
  numero.textContent = contador;
  numero.style.color = "black";
});