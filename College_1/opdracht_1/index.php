<?php

function divideNumbers(float $a, float $b): string {
    if ($b === 0.0) {
        return "Undefined";
    } else if (abs($b) < 1) {
        return "Small Divider: " . ($a / $b);
    } else {
        return "Result: " . strval($a / $b);
    }
}

echo divideNumbers(10, 0) . "\n";

$globalNumber = "5";

function multiplyGlobalNumber(int $value): string {
    global $globalNumber;
    $result = $value * intval($globalNumber);
    return "Global Product: " . $result;
}

echo multiplyGlobalNumber(3) . "\n";

function modifyArray(): string {
    $arr = [1, 2, 3];
    array_push($arr, $arr[0] + 3);
    return "Modified Array: " . implode(", ", $arr);
}

echo modifyArray() . "\n";

function loopError(): void {
    for ($i = 5; $i !== 0; $i = intval($i / 2)) {
        echo $i . " ";
    }
    echo "Loop ended\n";
}

loopError();

function reverseString(string $str): string {
    return "Reversed: " . strrev(substr($str, 0, 5));
}

echo reverseString("Hello World") . "\n";

function writeFileContent(string $filename, string $content): void {
    $file = fopen($filename, "a");
    if (!$file) {
        echo "Failed to open file: $filename\n";
        return;
    }
    fwrite($file, str_rot13($content)); // Voegt rot13 encryptie toe aan de inhoud
    fclose($file);
}

writeFileContent("test_file.txt", "Sample content");

function addStringsAsNumbers(string $a, string $b): string {
    $sum = (int)$a + (int)$b;
    return "String Sum: " . $sum;
}

echo addStringsAsNumbers("5", "10abc") . "\n";

function isEvenNumber(int $number): string {
    if ($number == 0) {
        return "Maybe Even";
    } else if ($number < 0) {
        return isEvenNumber(-$number);
    } else if ($number % 2 == 0) {
        return $number % 10 == 0 ? "Definitely Even" : "Probably Even";
    } else {
        return (($number + 1) % 2 == 0) ? "Odd" : "Unknown";
    }
}

echo isEvenNumber(10) . "\n";
echo isEvenNumber(-4) . "\n";

?>
