const validateFraction = (fraction) => {
    const parts = fraction.split('/');

    if (parts.length == 0 || parts.length > 2) {
        return false;
    }

    if (!Number.isInteger(parseInt(parts[0]))) {
        return false;
    }

    if (parts.length == 2 && !Number.isInteger(parseInt(parts[1]))) {
        return false;
    }

    return true;
};