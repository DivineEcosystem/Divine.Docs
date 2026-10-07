# <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands"></a> Class CSVCMsg\_UserCommands

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_UserCommands : IMessage<CSVCMsg_UserCommands>, IEquatable<CSVCMsg_UserCommands>, IDeepCloneable<CSVCMsg_UserCommands>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_UserCommands](Divine.Protobufs.Dota2.CSVCMsg\_UserCommands.md)

#### Implements

IMessage<CSVCMsg\_UserCommands\>, 
[IEquatable<CSVCMsg\_UserCommands\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_UserCommands\>, 
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
[EnumerableExtensions.In<CSVCMsg\_UserCommands\>\(CSVCMsg\_UserCommands, params CSVCMsg\_UserCommands\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands__ctor"></a> CSVCMsg\_UserCommands\(\)

```csharp
public CSVCMsg_UserCommands()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands__ctor_Divine_Protobufs_Dota2_CSVCMsg_UserCommands_"></a> CSVCMsg\_UserCommands\(CSVCMsg\_UserCommands\)

```csharp
public CSVCMsg_UserCommands(CSVCMsg_UserCommands other)
```

#### Parameters

`other` [CSVCMsg\_UserCommands](Divine.Protobufs.Dota2.CSVCMsg\_UserCommands.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands_CommandsFieldNumber"></a> CommandsFieldNumber

```csharp
public const int CommandsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands_Commands"></a> Commands

```csharp
public RepeatedField<CMsgServerUserCmd> Commands { get; }
```

#### Property Value

 RepeatedField<[CMsgServerUserCmd](Divine.Protobufs.Dota2.CMsgServerUserCmd.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_UserCommands> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_UserCommands](Divine.Protobufs.Dota2.CSVCMsg\_UserCommands.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_UserCommands Clone()
```

#### Returns

 [CSVCMsg\_UserCommands](Divine.Protobufs.Dota2.CSVCMsg\_UserCommands.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands_Equals_Divine_Protobufs_Dota2_CSVCMsg_UserCommands_"></a> Equals\(CSVCMsg\_UserCommands\)

```csharp
public bool Equals(CSVCMsg_UserCommands other)
```

#### Parameters

`other` [CSVCMsg\_UserCommands](Divine.Protobufs.Dota2.CSVCMsg\_UserCommands.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_UserCommands_"></a> MergeFrom\(CSVCMsg\_UserCommands\)

```csharp
public void MergeFrom(CSVCMsg_UserCommands other)
```

#### Parameters

`other` [CSVCMsg\_UserCommands](Divine.Protobufs.Dota2.CSVCMsg\_UserCommands.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_UserCommands_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

