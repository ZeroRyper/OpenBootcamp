import {suma,multiplica}  from './modulos/controller.js'
import chalk from 'chalk';

const sum=suma(4,5)
console.log(sum)

const mult=multiplica(1,2)
console.log(chalk.green(mult))