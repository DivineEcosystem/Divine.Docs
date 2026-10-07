# <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction"></a> Class CUserMessageRequestUtilAction

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageRequestUtilAction : IMessage<CUserMessageRequestUtilAction>, IEquatable<CUserMessageRequestUtilAction>, IDeepCloneable<CUserMessageRequestUtilAction>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageRequestUtilAction](Divine.Protobufs.Dota2.CUserMessageRequestUtilAction.md)

#### Implements

IMessage<CUserMessageRequestUtilAction\>, 
[IEquatable<CUserMessageRequestUtilAction\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageRequestUtilAction\>, 
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
[EnumerableExtensions.In<CUserMessageRequestUtilAction\>\(CUserMessageRequestUtilAction, params CUserMessageRequestUtilAction\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction__ctor"></a> CUserMessageRequestUtilAction\(\)

```csharp
public CUserMessageRequestUtilAction()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction__ctor_Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_"></a> CUserMessageRequestUtilAction\(CUserMessageRequestUtilAction\)

```csharp
public CUserMessageRequestUtilAction(CUserMessageRequestUtilAction other)
```

#### Parameters

`other` [CUserMessageRequestUtilAction](Divine.Protobufs.Dota2.CUserMessageRequestUtilAction.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Util1FieldNumber"></a> Util1FieldNumber

```csharp
public const int Util1FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Util2FieldNumber"></a> Util2FieldNumber

```csharp
public const int Util2FieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Util3FieldNumber"></a> Util3FieldNumber

```csharp
public const int Util3FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Util4FieldNumber"></a> Util4FieldNumber

```csharp
public const int Util4FieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Util5FieldNumber"></a> Util5FieldNumber

```csharp
public const int Util5FieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_HasUtil1"></a> HasUtil1

```csharp
public bool HasUtil1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_HasUtil2"></a> HasUtil2

```csharp
public bool HasUtil2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_HasUtil3"></a> HasUtil3

```csharp
public bool HasUtil3 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_HasUtil4"></a> HasUtil4

```csharp
public bool HasUtil4 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_HasUtil5"></a> HasUtil5

```csharp
public bool HasUtil5 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageRequestUtilAction> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageRequestUtilAction](Divine.Protobufs.Dota2.CUserMessageRequestUtilAction.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Util1"></a> Util1

```csharp
public int Util1 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Util2"></a> Util2

```csharp
public int Util2 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Util3"></a> Util3

```csharp
public int Util3 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Util4"></a> Util4

```csharp
public int Util4 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Util5"></a> Util5

```csharp
public int Util5 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_ClearUtil1"></a> ClearUtil1\(\)

```csharp
public void ClearUtil1()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_ClearUtil2"></a> ClearUtil2\(\)

```csharp
public void ClearUtil2()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_ClearUtil3"></a> ClearUtil3\(\)

```csharp
public void ClearUtil3()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_ClearUtil4"></a> ClearUtil4\(\)

```csharp
public void ClearUtil4()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_ClearUtil5"></a> ClearUtil5\(\)

```csharp
public void ClearUtil5()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Clone"></a> Clone\(\)

```csharp
public CUserMessageRequestUtilAction Clone()
```

#### Returns

 [CUserMessageRequestUtilAction](Divine.Protobufs.Dota2.CUserMessageRequestUtilAction.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_Equals_Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_"></a> Equals\(CUserMessageRequestUtilAction\)

```csharp
public bool Equals(CUserMessageRequestUtilAction other)
```

#### Parameters

`other` [CUserMessageRequestUtilAction](Divine.Protobufs.Dota2.CUserMessageRequestUtilAction.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_MergeFrom_Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_"></a> MergeFrom\(CUserMessageRequestUtilAction\)

```csharp
public void MergeFrom(CUserMessageRequestUtilAction other)
```

#### Parameters

`other` [CUserMessageRequestUtilAction](Divine.Protobufs.Dota2.CUserMessageRequestUtilAction.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestUtilAction_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

