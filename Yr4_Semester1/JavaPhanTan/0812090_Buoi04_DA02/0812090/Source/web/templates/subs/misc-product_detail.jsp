<script>
	$('.addtocartbtn').click(function() {
		var quantity = $('input[name=quantity]').val();
		if (quantity)
			$.post("cart", {quantity: quantity, id: ${ref.id}});
	});
</script>