# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat"></a> Class CDOTAUserMsg\_BeastChat

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_BeastChat : IMessage<CDOTAUserMsg_BeastChat>, IEquatable<CDOTAUserMsg_BeastChat>, IDeepCloneable<CDOTAUserMsg_BeastChat>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_BeastChat](Divine.Protobufs.Dota2.CDOTAUserMsg\_BeastChat.md)

#### Implements

IMessage<CDOTAUserMsg\_BeastChat\>, 
[IEquatable<CDOTAUserMsg\_BeastChat\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_BeastChat\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_BeastChat\>\(CDOTAUserMsg\_BeastChat, params CDOTAUserMsg\_BeastChat\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat__ctor"></a> CDOTAUserMsg\_BeastChat\(\)

```csharp
public CDOTAUserMsg_BeastChat()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_"></a> CDOTAUserMsg\_BeastChat\(CDOTAUserMsg\_BeastChat\)

```csharp
public CDOTAUserMsg_BeastChat(CDOTAUserMsg_BeastChat other)
```

#### Parameters

`other` [CDOTAUserMsg\_BeastChat](Divine.Protobufs.Dota2.CDOTAUserMsg\_BeastChat.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_FormatFieldNumber"></a> FormatFieldNumber

```csharp
public const int FormatFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_TargetFieldNumber"></a> TargetFieldNumber

```csharp
public const int TargetFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_TeamFieldNumber"></a> TeamFieldNumber

```csharp
public const int TeamFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_Format"></a> Format

```csharp
public string Format { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_HasFormat"></a> HasFormat

```csharp
public bool HasFormat { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_HasTarget"></a> HasTarget

```csharp
public bool HasTarget { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_HasTeam"></a> HasTeam

```csharp
public bool HasTeam { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_BeastChat> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_BeastChat](Divine.Protobufs.Dota2.CDOTAUserMsg\_BeastChat.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_Target"></a> Target

```csharp
public string Target { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_Team"></a> Team

```csharp
public uint Team { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_ClearFormat"></a> ClearFormat\(\)

```csharp
public void ClearFormat()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_ClearTarget"></a> ClearTarget\(\)

```csharp
public void ClearTarget()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_ClearTeam"></a> ClearTeam\(\)

```csharp
public void ClearTeam()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_BeastChat Clone()
```

#### Returns

 [CDOTAUserMsg\_BeastChat](Divine.Protobufs.Dota2.CDOTAUserMsg\_BeastChat.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_"></a> Equals\(CDOTAUserMsg\_BeastChat\)

```csharp
public bool Equals(CDOTAUserMsg_BeastChat other)
```

#### Parameters

`other` [CDOTAUserMsg\_BeastChat](Divine.Protobufs.Dota2.CDOTAUserMsg\_BeastChat.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_"></a> MergeFrom\(CDOTAUserMsg\_BeastChat\)

```csharp
public void MergeFrom(CDOTAUserMsg_BeastChat other)
```

#### Parameters

`other` [CDOTAUserMsg\_BeastChat](Divine.Protobufs.Dota2.CDOTAUserMsg\_BeastChat.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BeastChat_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

