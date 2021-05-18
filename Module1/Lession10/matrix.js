function generateMatrix(size, min, max){
    let matrix = [];
    for(let i=0;i<size;i++){
        let arr = [];
        for(let j=0;j<size;j++){
            arr[j] = Math.floor(Math.random()*(max - min + 1) + min);
        }   
        matrix[i] = arr;
    }
    return matrix;
}

function isEvenValue(number){
    // if(number % 2 == 0)
    //     return true;
    // return false;

    return number % 2 == 0;
}
function totalEvenValues(matrix){
    let size = matrix.length;
    let total = 0;
    for(let i=0;i<size; i++){
        for(let j=0;j<size;j++){
            if(isEvenValue(matrix[i][j])){
                total += matrix[i][j];
            }
        }
    }
    return total;
}

function printMatrix(matrix){
    let size = matrix.length;
    for(let i=0;i<size; i++){
        for(let j=0;j<size;j++){
            document.write(`${matrix[i][j] }    `);
        }
        document.write('<br>');
    }
}

function totalValueOnPrimary(matrix){
    let size = matrix.length;
    let total = 0;
    // for(let i=0;i<size; i++){
    //     for(let j=0;j<size;j++){
    //         if(i==j){
    //             total += matrix[i][j];
    //         }
    //     }
    // }
    for(let i=0;i<size;i++){
        total += matrix[i][i];
    }
    return total;
}


function totalValuesOnSecondary(matrix){
    let size = matrix.length;
    let total = 0;
    // for(let i=0;i<size; i++){
    //     for(let j=0;j<size;j++){
    //         if(i+j == size - 1){
    //             total += matrix[i][j];
    //         }
    //     }
    // }
    for(let i=0;i<size;i++){
        total += matrix[size-i-1][i];
    }
    return total;
}

function printPrimaryMatrix(matrix){
    let size = matrix.length;
    for(let i=0;i<size; i++){
        for(let j=0;j<size;j++){
            if(i>=j){
                document.write(`${matrix[i][j] }    `);
            }
        }
        document.write('<br>');
    }
}

function printSecondaryMatrix(matrix){
    let size = matrix.length;
    for(let i=0;i<size; i++){
        for(let j=0;j<size;j++){
            if(i<=j){
                document.write(`${matrix[i][j] }    `);
            }
            else{
                document.write(`---    `);
            }
        }
        document.write('<br>');
    }
}

function totalBorderMatrix(matrix){
    let total = 0;
    let size = matrix.length;
    for(let j=0; j<size;j++){
        total += matrix[0][j] + matrix[size-1][j];
    }
    for(let i=1;i<size-1;i++){
        total += matrix[i][0] + matrix[i][size-1];
    }

    return total;
}

function main(){
    let size = 3;
    let min = 1;
    let max = 9;
    let matrix = generateMatrix(size, min, max);
    printMatrix(matrix);
    document.write(`Total even values of matrix: ${totalEvenValues(matrix)} <br>`);
    document.write(`Total values on primary of matrix: ${totalValueOnPrimary(matrix)} <br>`);
    document.write(`Total values on secondary of matrix: ${totalValuesOnSecondary(matrix)} <br>`);
    document.write(`Total values on border of matrix: ${totalBorderMatrix(matrix)} <br>`);
    printPrimaryMatrix(matrix);
    document.write(`-------------------------------<br>`);
    printSecondaryMatrix(matrix);
}

main();