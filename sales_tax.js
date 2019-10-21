var $ = function(id) {
    return document.getElementById(id);
}

var processEntries = function()

{
    var inpSubTotal = parseFloat($("subtotal").value);
    var inpTaxRate = parseFloat($("tax_rate").value);

    if (inpSubTotal <= 0 || inpSubTotal > 10000) {
        $("SubTotal").innerHTML = "Subtotal must be > 0 and < 10000";
    }

    if (inpTaxRate <= 0 || inpTaxRate > 12) {
        $("TaxRate").innerHTML = "Tax Rate must be > 0 and < 12";
    }

    var calculTax = inpSubTotal * (inpTaxRate / 100);
    calculTax = parseFloat(calculTax.toFixed(2));
    var totalAmt = inpSubTotal + calculTax;
    $("sales_tax").value = calculTax;
    $("total").value = totalAmt.toFixed(2);
}

var clear_click = function() {
    $("subtotal").value = "";
    $("tax_rate").value = "";
    $("total").value = "";
    $("sales_tax").value = "";
}

function clearSubTotal()

{
    $("subtotal").value = "";
}

function clearTaxRate() {
    $("tax_rate").value = "";
}

window.onload = function() {
    $("calculate").onclick = processEntries;
}