# <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog"></a> Class CMsgNotifyWatchdog

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgNotifyWatchdog : IMessage<CMsgNotifyWatchdog>, IEquatable<CMsgNotifyWatchdog>, IDeepCloneable<CMsgNotifyWatchdog>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgNotifyWatchdog](Divine.Protobufs.Steam.CMsgNotifyWatchdog.md)

#### Implements

IMessage<CMsgNotifyWatchdog\>, 
[IEquatable<CMsgNotifyWatchdog\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgNotifyWatchdog\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CMsgNotifyWatchdog\>\(CMsgNotifyWatchdog, params CMsgNotifyWatchdog\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog__ctor"></a> CMsgNotifyWatchdog\(\)

```csharp
public CMsgNotifyWatchdog()
```

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog__ctor_Divine_Protobufs_Steam_CMsgNotifyWatchdog_"></a> CMsgNotifyWatchdog\(CMsgNotifyWatchdog\)

```csharp
public CMsgNotifyWatchdog(CMsgNotifyWatchdog other)
```

#### Parameters

`other` [CMsgNotifyWatchdog](Divine.Protobufs.Steam.CMsgNotifyWatchdog.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_AlertTypeFieldNumber"></a> AlertTypeFieldNumber

```csharp
public const int AlertTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_AppidFieldNumber"></a> AppidFieldNumber

```csharp
public const int AppidFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_CriticalFieldNumber"></a> CriticalFieldNumber

```csharp
public const int CriticalFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_RecipientFieldNumber"></a> RecipientFieldNumber

```csharp
public const int RecipientFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_SourceFieldNumber"></a> SourceFieldNumber

```csharp
public const int SourceFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_TextFieldNumber"></a> TextFieldNumber

```csharp
public const int TextFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_TimeFieldNumber"></a> TimeFieldNumber

```csharp
public const int TimeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_AlertType"></a> AlertType

```csharp
public uint AlertType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_Appid"></a> Appid

```csharp
public uint Appid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_Critical"></a> Critical

```csharp
public bool Critical { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_HasAlertType"></a> HasAlertType

```csharp
public bool HasAlertType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_HasAppid"></a> HasAppid

```csharp
public bool HasAppid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_HasCritical"></a> HasCritical

```csharp
public bool HasCritical { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_HasRecipient"></a> HasRecipient

```csharp
public bool HasRecipient { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_HasSource"></a> HasSource

```csharp
public bool HasSource { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_HasText"></a> HasText

```csharp
public bool HasText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_HasTime"></a> HasTime

```csharp
public bool HasTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_Parser"></a> Parser

```csharp
public static MessageParser<CMsgNotifyWatchdog> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgNotifyWatchdog](Divine.Protobufs.Steam.CMsgNotifyWatchdog.md)\>

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_Recipient"></a> Recipient

```csharp
public string Recipient { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_Source"></a> Source

```csharp
public uint Source { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_Text"></a> Text

```csharp
public string Text { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_Time"></a> Time

```csharp
public uint Time { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_ClearAlertType"></a> ClearAlertType\(\)

```csharp
public void ClearAlertType()
```

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_ClearAppid"></a> ClearAppid\(\)

```csharp
public void ClearAppid()
```

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_ClearCritical"></a> ClearCritical\(\)

```csharp
public void ClearCritical()
```

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_ClearRecipient"></a> ClearRecipient\(\)

```csharp
public void ClearRecipient()
```

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_ClearSource"></a> ClearSource\(\)

```csharp
public void ClearSource()
```

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_ClearText"></a> ClearText\(\)

```csharp
public void ClearText()
```

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_ClearTime"></a> ClearTime\(\)

```csharp
public void ClearTime()
```

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_Clone"></a> Clone\(\)

```csharp
public CMsgNotifyWatchdog Clone()
```

#### Returns

 [CMsgNotifyWatchdog](Divine.Protobufs.Steam.CMsgNotifyWatchdog.md)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_Equals_Divine_Protobufs_Steam_CMsgNotifyWatchdog_"></a> Equals\(CMsgNotifyWatchdog\)

```csharp
public bool Equals(CMsgNotifyWatchdog other)
```

#### Parameters

`other` [CMsgNotifyWatchdog](Divine.Protobufs.Steam.CMsgNotifyWatchdog.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_MergeFrom_Divine_Protobufs_Steam_CMsgNotifyWatchdog_"></a> MergeFrom\(CMsgNotifyWatchdog\)

```csharp
public void MergeFrom(CMsgNotifyWatchdog other)
```

#### Parameters

`other` [CMsgNotifyWatchdog](Divine.Protobufs.Steam.CMsgNotifyWatchdog.md)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgNotifyWatchdog_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

