﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            name: CI

                on: [push]

                jobs:
                build:

                runs-on: ubuntu-latest

                steps:
                - uses: actions/checkout @v1
                - name: Run a one-line script
                  run: echo Hello, world!
                - name: Run a multi-line script
                    run: |
                    echo Add other actions to build,
                    echo test, and deploy your project.
        }
    }
}
