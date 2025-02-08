namespace Yggdrasil;

using System.Runtime.InteropServices;

public sealed class YggStack {
    public static void Run(string[] args) {
        if (args is null)
            throw new ArgumentNullException(nameof(args));
        YggstackMain(args.Length, args);
    }

    [DllImport("yggstack")]
    static extern void YggstackMain(int argc, string[] argv);
}