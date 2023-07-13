# Mod-of-Power
# Description:
Design an efficient algorithm to calculate
𝑹 = (𝑩^𝑷)𝒎𝒐𝒅 𝑴
for large values of B, P, and M.
# Theorem:
(A × B × C) mod N = [(A mod N) × (B mod N) × (c mod N)] mod N
Since we want B to the power P and take modulus M, so it is going to be:
((B mod M) × (B mod M) × (B mod M) × ...(P times)) mod M
