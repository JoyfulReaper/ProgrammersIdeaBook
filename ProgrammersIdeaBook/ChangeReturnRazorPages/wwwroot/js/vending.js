let credit = 0;

const update = () => {
    $('#credit').html(
    new Intl.NumberFormat('en-US', { style: 'currency', currency: 'USD' }).format(credit));
}

$(() => {
    $('#btnDelete').click((e) => {
        const productId = $(e.target).data("itemid");

        const options = {
            headers: {
                RequestVerificationToken: $('input:hidden[name="__RequestVerificationToken"]').val()
            },
            method: "POST",
            url: "/Index?handler=delete",
            data: { productId: productId }
        };

        $.ajax(options).done((data) => {
            location.reload();
        }).fail(() => {
            alert("Unable to delete");
        });
    });

    $('.buyButton').click((e) => {
        const price = $(e.target).data("price");
        const productId = $(e.target).data("itemid");

        if(price > credit)
        {
            alert("Not enough credits!");
            return;
        }
        const totalChange = credit - price;

        const options = {
            headers: {
                RequestVerificationToken: $('input:hidden[name="__RequestVerificationToken"]').val()
            },
            method: "POST",
            url: "/Index",
            data: { totalChange: totalChange, productId: productId }
        };

        $.ajax(options).done((data) => {
            let out = "";
            data.change.forEach((unit) => {
                out += "<span>" + unit.pluralName + ":</span> " + unit.quantity + "<br />";
            });

            if(data.change.length < 4)
            {
                let add = 4 - data.change.length;
                for(let i = 0; i < add; i++)
                {
                    out += "<br />";
                }
            }

            $('#change').html(out);
            $(`.stock[data-itemid='${productId}']`).html(data.stock);
            credit = 0;
            $('#credit').html('');
        }).fail(() => {
            alert("Ajax Call Failed!");
        })
    });

    $('#btnDollar').click(() => {
        credit += 1;
        update();
    });
    $('#btnQuarter').click(() => {
        credit += .25;
        update();
    });
    $('#btnDime').click(() => {
        credit += .10;
        update();
    });
    $('#btnNickle').click(() => {
        credit += .05;
        update();
    });
    $('#btnPenny').click(() => {
        credit += .01;
        update();
    });

});