(function () {

    $(function () {

        //change text button and icon collapse
        $('[change-collapse-icon]').on('shown.bs.collapse', function () {
            var $chevronup = $(this).attr('id');
            $('[data-target="#' + $chevronup + '"]').html('<i class="fa fa-chevron-up"></i> Less &nbsp;');
        });

        $('[change-collapse-icon]').on('hidden.bs.collapse', function () {
            var $chevrondown = $(this).attr('id');
            $('[data-target="#' + $chevrondown + '"]').html('<i class="fa fa-chevron-down"></i> More');
        });


        //animate numbers
        $('[data-animate-number]').each(function () {

            var $this = $(this);
            jQuery({ Counter: 0 }).animate({ Counter: $this.text() }, {
                duration: 2900,
                easing: 'swing',
                step: function () {
                    $this.text(Math.ceil(this.Counter));
                }
            });
        });
    });
})();

