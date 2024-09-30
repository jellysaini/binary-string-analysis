# Binary String Analysis

## Overview

This repository contains a C# function that evaluates binary strings based on two criteria:

1. **Equal number of '0's and '1's**.
2. **For every prefix of the string, the number of '1's should never be less than the number of '0's**.

A binary string that satisfies both of these conditions is considered a "good" binary string.

## Function Details

The function `AnalyzeBinaryString` takes a binary string (a string containing only '0's and '1's) and determines if it qualifies as a "good" binary string.

### Criteria

1. **Equal number of '0's and '1's**:  
   The binary string must contain an equal number of '1's and '0's. 

2. **Prefix Condition**:  
   For every prefix the number of '1's must be **greater than or equal** to the number of '0's.

## Usage

### Function Signature:

```csharp
public static string AnalyzeBinaryString(string binaryString)
