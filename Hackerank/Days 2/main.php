<?php

function solve($meal_cost, $tip_percent, $tax_percent)
{
    $tip = $meal_cost * $tip_percent / 100;
    $tax = $meal_cost * $tax_percent / 100;

    $total = $meal_cost + $tip + $tax;

    echo round($total) . PHP_EOL;
}

$meal_cost = doubleval(trim(fgets(STDIN)));
$tip_percent = intval(trim(fgets(STDIN)));
$tax_percent = intval(trim(fgets(STDIN)));

solve($meal_cost, $tip_percent, $tax_percent);