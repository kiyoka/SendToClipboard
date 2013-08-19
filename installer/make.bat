

candle -ext WiXNetFxExtension                     SendToClipboard.wxs
light  -ext WiXNetFxExtension -ext WixUIExtension SendToClipboard.wixobj 
copy SendToClipboard.msi SendToClipboard-1.0.0.msi
